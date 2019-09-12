using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;



namespace kaizenAlgoritmos.Class.Office
{
    class claseExcel
    {
        public claseExcel() {

        }

        public Workbook workbook;
        public Worksheet worksheet;
        public Range range;

        public string dirArchivo;

        public void generarListado(string dirArchivo)
        {
            Application miExcel = new Application();
            miExcel.Visible = false;
            Workbook workbook = miExcel.Workbooks.Open(dirArchivo);
            Worksheet worksheet_PM = miExcel.Worksheets.Item[2];
            Worksheet worksheet_OC = miExcel.Worksheets.Item[3];
            Worksheet worksheet_REC = miExcel.Worksheets.Item[4];
            Worksheet worksheet_TRACKPM = miExcel.Worksheets.Item[5];
            Worksheet worksheet_TRACKOC = miExcel.Worksheets.Item[6];
            Worksheet worksheet_TRACKREC = miExcel.Worksheets.Item[7];

            int pm, oc, rec, totalPM, totalOC, totalREC, fila;
            string nroPM, nroOC, nroREC, origenPM, origenOC, origenREC, tipoTRACK;

            totalPM = 100;
            totalOC = 100;
            totalREC = 100;

            fila = 1;

            for (pm = 0; pm < totalPM; pm++)
            {
                nroPM = worksheet_PM.Cells[pm, 2];


                for (oc = 1; oc < totalOC; oc++)
                {
                    nroOC = worksheet_TRACKOC.Cells[oc, 2];

                    for (rec = 1; rec < totalREC; rec++)
                    {

                        nroREC = worksheet_TRACKREC.Cells[rec, 2];

                        rec++;
                    }
                    oc++;
                }

                pm++;
            }

            miExcel.Quit();

        }
    }
}
