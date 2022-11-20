using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace FormsMauiMigration.Models
{
    public class Monkey : BaseModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        public string ImageUrl { get; set; }
    }
}