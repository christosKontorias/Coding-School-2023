using SerializerLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using System.Text.RegularExpressions;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using CarServiceCenterLib.Models;
using CarServiceCenterLib.Orm.Repositories;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Session_16.Win {
    public partial class CustomersAndCarsForm : Form {
        private CarServiceCenter _carServiceCenter;
        private Serializer _serializer;

        public CustomersAndCarsForm(CarServiceCenter carServiceCenter) {
            InitializeComponent();
            _serializer = new Serializer();
            _carServiceCenter = carServiceCenter;
        }
        private void CustomersAndCarsForm_Load(object sender, EventArgs e) {
            SetControlProperties();
            _serializer = new Serializer();
        }
        private void SetControlProperties() {
            _serializer = new Serializer();
            CustomerRepo customerRepo = new CustomerRepo();
            CarRepo carRepo = new CarRepo();
            bsCustomers.DataSource = customerRepo.GetAll();
            grdCustomers.DataSource = bsCustomers;
            bsCars.DataSource = carRepo.GetAll();
            grdCars.DataSource = bsCars;
        }

        //Customers GridView
        private void grvCustomers_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e) {
            GridView view = sender as GridView;
            CustomerRepo customerRepo = new CustomerRepo();
            Guid id = Guid.Parse(view.GetRowCellValue(view.FocusedRowHandle, colID).ToString());
            customerRepo.Delete(id);
        }
        private void grvCustomers_RowUpdated(object sender, RowObjectEventArgs e) {
            GridView view = sender as GridView;
            CustomerRepo customerRepo = new CustomerRepo();
            Guid id = Guid.Parse(view.GetRowCellValue(view.FocusedRowHandle, colID).ToString());
            customerRepo.Update(id, (Customer)bsCustomers.Current);
        }
        private void grvCustomers_ValidateRow(object sender, ValidateRowEventArgs e) {
            CustomerRepo customerRepo = new CustomerRepo();
            GridView view = sender as GridView;
            GridColumn colName = view.Columns["Name"];
            GridColumn colSurname = view.Columns["Surname"];
            GridColumn colPhone = view.Columns["Phone"];
            GridColumn colTIN = view.Columns["TIN"];
            Guid id = Guid.Parse(view.GetRowCellValue(e.RowHandle, colID).ToString());
            String name = view.GetRowCellValue(e.RowHandle, colName) as String;
            String surname = view.GetRowCellValue(e.RowHandle, colSurname) as String;
            String phone = view.GetRowCellValue(e.RowHandle, colPhone) as String;
            String tin = view.GetRowCellValue(e.RowHandle, colTIN) as String;
            if (name == null) {
                e.Valid = false;
                view.SetColumnError(colName, "Insert Valid Name");
            } else if (name == "") {
                e.Valid = false;
                view.SetColumnError(colName, "Fill Name cell");
            }
            if (surname == null) {
                e.Valid = false;
                view.SetColumnError(colSurname, "Insert Valid Surname");
            } else if (surname == "") {
                e.Valid = false;
                view.SetColumnError(colSurname, "Fill Surname cell");
            }
            if (phone == null) {
                e.Valid = false;
                view.SetColumnError(colPhone, "Insert Valid Phone");
            } else if (phone == "") {
                e.Valid = false;
                view.SetColumnError(colPhone, "Fill Phone cell");
            } else if (phone.Count() != 10 && !Regex.IsMatch(phone, @"^[0-9]+$")) {
                e.Valid = false;
                view.SetColumnError(colPhone, "Insert Valid Phone");
            }
            if (tin == null) {
                e.Valid = false;
                view.SetColumnError(colTIN, "Insert Valid TIN");
            } else if (tin == "") {
                e.Valid = false;
                view.SetColumnError(colTIN, "Fill TIN cell");
            } else if (tin.Count() != 9 && !Regex.IsMatch(tin, @"^[0-9]+$")) {
                e.Valid = false;
                view.SetColumnError(colTIN, "Insert Valid TIN");
            }
            if (e.Valid) {
                view.ClearColumnErrors();
                customerRepo.Add((Customer)bsCustomers.Current);
            }
        }
        private void grvCustomers_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e) {
            ColumnView view = sender as ColumnView;
            GridColumn column = (e as EditFormValidateEditorEventArgs)?.Column ?? view.FocusedColumn;
            String cellVal = e.Value as String;
            if (column.FieldName == "Name") {
                if (cellVal == null) {
                    e.Valid = false;
                    view.SetColumnError(colName, "Insert Valid Name");
                } else if (cellVal == "") {
                    e.Valid = false;
                    view.SetColumnError(colName, "Fill Name cell");
                }
            }
            if (column.FieldName == "Surname") {
                if (cellVal == null) {
                    e.Valid = false;
                    view.SetColumnError(colSurname, "Insert Valid Surname");
                } else if (cellVal == "") {
                    e.Valid = false;
                    view.SetColumnError(colSurname, "Fill Surname cell");
                }
            }
            if (column.FieldName == "Phone") {
                if (cellVal == null) {
                    e.Valid = false;
                    view.SetColumnError(colPhone, "Insert Valid Phone");
                } else if (cellVal == "") {
                    e.Valid = false;
                    view.SetColumnError(colPhone, "Fill Car Phone cell");
                } else if (cellVal.Count() == 10 && Regex.IsMatch(cellVal, @"^[0-9]+$")) {
                } else {
                    e.Valid = false;
                    view.SetColumnError(colPhone, "Insert Valid Phone with format for e.g [6912345678]");
                }
            }
            if (column.FieldName == "TIN") {
                if (cellVal == null) {
                    e.Valid = false;
                    view.SetColumnError(colTIN, "Insert Valid TIN");
                } else if (cellVal == "") {
                    e.Valid = false;
                    view.SetColumnError(colTIN, "Fill TIN cell");
                } else if (cellVal.Count() == 9 && Regex.IsMatch(cellVal, @"^[0-9]+$")) {
                } else {
                    e.Valid = false;
                    view.SetColumnError(colPhone, "Insert Valid TIN with format for e.g [165485219]");
                }
            }
        }

        //Cars GridView
        private void grvCars_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e) {
            GridView view = sender as GridView;
            CarRepo carRepo = new CarRepo();
            Guid id = Guid.Parse(view.GetRowCellValue(view.FocusedRowHandle, colCarID).ToString());
            carRepo.Delete(id);
        }
        private void grvCars_RowUpdated(object sender, RowObjectEventArgs e) {
            GridView view = sender as GridView;
            CarRepo carRepo = new CarRepo();
            Guid id = Guid.Parse(view.GetRowCellValue(view.FocusedRowHandle, colCarID).ToString());
            carRepo.Update(id, (Car)bsCars.Current);
        }
        private void grvCars_ValidateRow(object sender, ValidateRowEventArgs e) {
            CarRepo carRepo = new CarRepo();
            GridView view = sender as GridView;
            GridColumn colBrand = view.Columns["Brand"];
            GridColumn colModel = view.Columns["Model"];
            GridColumn colRegNum = view.Columns["CarRegistrationNumber"];
            Guid id = Guid.Parse(view.GetRowCellValue(e.RowHandle, colCarID).ToString());
            String brand = view.GetRowCellValue(e.RowHandle, colBrand) as String;
            String model = view.GetRowCellValue(e.RowHandle, colModel) as String;
            String regNum = view.GetRowCellValue(e.RowHandle, colRegNum) as String;
            // Brand Cell
            if (brand == null) {
                e.Valid = false;
                view.SetColumnError(colBrand, "Insert Valid Brand");
            } else if (brand == "") {
                e.Valid = false;
                view.SetColumnError(colBrand, "Fill Brand cell");
            }
            // Model Cell
            if (model == null) {
                e.Valid = false;
                view.SetColumnError(colModel, "Insert Valid Model");
            } else if (model == "") {
                e.Valid = false;
                view.SetColumnError(colModel, "Fill Model cell");
            }
            // Car Registration Number Cell
            if (regNum == null) {
                e.Valid = false;
                view.SetColumnError(colRegNum, "Insert Valid Registration number");
            } else if (regNum == "") {
                view.SetColumnError(colModel, "Fill Car Registration Number cell");
            } else if (regNum.Count() == 8 && Regex.IsMatch(regNum.Substring(0, 3), @"^[a-zA-Z]+$") && regNum[3] == ' ' && Regex.IsMatch(regNum.Substring(4, 4), @"^[1-9]+$")) {
                // Correct
            } else {
                e.Valid = false;
                view.SetColumnError(colRegNum, "Insert Valid Registration number with format for e.g [IZM 1234] ");
            }

            if (e.Valid) {
                view.ClearColumnErrors();
                carRepo.Add((Car)bsCars.Current);
            }
        }
        private void grvCars_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e) {
            ColumnView view = sender as ColumnView;
            GridColumn column = (e as EditFormValidateEditorEventArgs)?.Column ?? view.FocusedColumn;
            String cellVal = e.Value as String;
            if (column.FieldName == "Brand") {
                // colBrand changed
                if (cellVal == null) {
                    e.Valid = false;
                    view.SetColumnError(colBrand, "Insert Valid Brand");
                } else if (cellVal == "") {
                    e.Valid = false;
                    view.SetColumnError(colBrand, "Fill Brand cell");
                }
            } else if (column.FieldName == "Model") {
                // colModel changed
                if (cellVal == null) {
                    e.Valid = false;
                    view.SetColumnError(colModel, "Insert Valid Model");
                } else if (cellVal == "") {
                    e.Valid = false;
                    view.SetColumnError(colModel, "Fill Model cell");
                }
            } else if (column.FieldName == "CarRegistrationNumber") {
                // colCarRegistrationNumber changed
                if (cellVal == null) {
                    e.Valid = false;
                    view.SetColumnError(colCarRegistrationNumber, "Insert Valid Registration number");
                } else if (cellVal == "") {
                    e.Valid = false;
                    view.SetColumnError(colCarRegistrationNumber, "Fill Car Registration Number cell");
                } else if (cellVal.Count() == 8 && Regex.IsMatch(cellVal.Substring(0, 3), @"^[a-zA-Z]+$") && cellVal[3] == ' ' && Regex.IsMatch(cellVal.Substring(4, 4), @"^[0-9]+$")) {
                    // Correct
                } else {
                    e.Valid = false;
                    view.SetColumnError(colCarRegistrationNumber, "Insert Valid Registration number with format for e.g [IZM 1234] ");
                }
            }
        }

        //Button Save
        private void btnSave_Click(object sender, EventArgs e) {
            _serializer.SerializeToFile(_carServiceCenter, "CarServiceCenter.json");
            DevExpress.XtraEditors.XtraMessageBox.Show("Saved!");
        }
        private void btnSave_MouseEnter(object sender, EventArgs e) {
            btnSave.FlatAppearance.MouseOverBackColor = btnSave.BackColor;
            btnSave.ForeColor = Color.Blue;
            btnSave.FlatAppearance.BorderColor = Color.Red;
            btnSave.FlatAppearance.BorderSize = 2;
        }
        private void btnSave_MouseLeave(object sender, EventArgs e) {
            btnSave.ForeColor = Color.Black;
            btnSave.FlatAppearance.BorderColor = Color.Black;
            btnSave.FlatAppearance.BorderSize = 2;
        }

        //Button Close
        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void btnClose_MouseEnter(object sender, EventArgs e) {
            btnClose.FlatAppearance.MouseOverBackColor = btnClose.BackColor;
            btnClose.ForeColor = Color.Blue;
            btnClose.FlatAppearance.BorderColor = Color.Red;
            btnClose.FlatAppearance.BorderSize = 2;
        }
        private void btnClose_MouseLeave(object sender, EventArgs e) {
            btnClose.ForeColor = Color.Black;
            btnClose.FlatAppearance.BorderColor = Color.Black;
            btnClose.FlatAppearance.BorderSize = 2;
        }
    }
}