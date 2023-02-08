using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Mechanical;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_2
{
    [Transaction(TransactionMode.Manual)]
    public class Main : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Document doc = uidoc.Document;

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string name = "NWCExport.nwd";
            NavisworksExportOptions nwcOptions = new NavisworksExportOptions();
            doc.Export(path, name, nwcOptions);
            
            return Result.Succeeded;

        }
    }
}
