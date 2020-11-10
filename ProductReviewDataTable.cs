using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProductReviewManagement
{
    class ProductReviewDataTable
    {
        DataTable table = new DataTable();
        /// <summary>
        /// UC 8: 
        /// Create data table and add data to it
        /// </summary>
        public void CreateDataTable()
        {
            ///Adding Columns
            table.Columns.Add("UserID");
            table.Columns.Add("ProductID");
            table.Columns.Add("Rating");
            table.Columns.Add("Review");
            table.Columns.Add("isLike");
            ///Inserting Data
            table.Rows.Add("1", "1", 5, "Good", true);
            table.Rows.Add("2", "3", 3, "Average", true);
            table.Rows.Add("3", "4", 4, "Good", true);
            table.Rows.Add("4", "5", 5, "Good", true);
            table.Rows.Add("5", "4", 3, "Average", true);
            table.Rows.Add("6", "5", 1, "Bad", false);
            table.Rows.Add("7", "10", 5, "Good", true);
            table.Rows.Add("8", "10", 5, "Good", true);
            table.Rows.Add("9", "3", 4, "Good", true);
            table.Rows.Add("10", "2", 2, "Bad", false);
            table.Rows.Add("11", "3", 3, "Average", true);
            table.Rows.Add("12", "1", 3, "Average", false);
            table.Rows.Add("13", "1", 4, "Good", true);
            table.Rows.Add("14", "2", 5, "Good", true);
            table.Rows.Add("15", "20", 1, "bad", false);
            table.Rows.Add("16", "15", 10, "Excellent", true);
            table.Rows.Add("17", "12", 1, "Poor", true);
            table.Rows.Add("18", "21",7, "Average", false);
            table.Rows.Add("19", "22", 10, "Excellent", true);
            table.Rows.Add("20", "21", 0, "Poor", true);
        }
        /// <summary>
        /// UC 9:
        /// Retrieve data from table by isLike condition
        /// </summary>
        public void RetrieveDataWithIsLike()
        {
            CreateDataTable();
            var recordedData = from products in table.AsEnumerable()
                               where products.Field<bool>("isLike") == true
                               select products;
            foreach (var productReview in recordedData)
            {
                Console.WriteLine("Product ID: " + productReview.Field<string>("ProductID") + " UserID: " + productReview.Field<string>("UserID") + " Rating: " + productReview.Field<string>("Rating") + " Review: " + productReview.Field<string>("Review") + " isLike: " + productReview.Field<string>("isLike"));
            }
        }
    }
}
