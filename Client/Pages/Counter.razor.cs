using IMDBlite.Shared.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using static IMDBlite.Client.Shared.MainLayout;

namespace IMDBlite.Client.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;
 
        public void IncrementCount()
        {
            currentCount++;
        }
    }
}
