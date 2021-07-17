using BasicExampleofInvokingJavaScriptFunction.Client.Shared;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicExampleofInvokingJavaScriptFunction.Client.Pages
{
    public partial class Index
    {
        private List<Data> d;
        protected override void OnInitialized()
        {
            d = new List<Data>()
            {

            new Data() { Id = 101, Name = "Aman", Address = "Noida" },
                new Data() { Id = 102, Name = "manish", Address = "Gr Noida" },
                new Data() { Id = 103, Name = "Ajay", Address = "Noida" },
                new Data() { Id = 104, Name = "Vijay", Address = "Gr Noida" }
            };
        }
        private async Task DeleteAsync(Data d1)
        {
            //var confirmed = await js.InvokeAsync<bool>("confirm",$"Are You want to Delete?{d1.Id}");
            var confirmed = await js.InvokeAsync<bool>("confirm", $"Are You Sure Want to Delete{d1.Id}{d1.Name}{d1.Address}");
            if (confirmed)
            {
                d.Remove(d1);
            }
        }
        public bool check;
    }
}
