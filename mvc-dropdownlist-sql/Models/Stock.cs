namespace mvc_dropdownlist_sql.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Stock
    {
        public int StockId { get; set; }
        public int ProductId { get; set; }
        public Nullable<int> Count { get; set; }

        [NotMapped]
        public List<Product> ProductCollection { get; set; }
    }
}
