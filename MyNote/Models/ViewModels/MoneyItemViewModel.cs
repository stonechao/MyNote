using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MyNote.Models.ViewModels
{
    public class MoneyItemViewModel
    {
        [DisplayName("類別")]
        public int NoteType { get; set; }

        [DisplayName("日期")]
        public float NoteAmount { get; set; }

        [DisplayName("金額")]
        public DateTime NoteDate { get; set; }

        [DisplayName("備註")]
        public string NoteRemark { get; set; }
    }
}