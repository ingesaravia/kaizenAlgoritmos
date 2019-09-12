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
            Worksheet worksheet = workbook.Sheets[1];
            Worksheet worksheet_PM = workbook.Sheets[2];
            Worksheet worksheet_OC = workbook.Sheets[3];
            Worksheet worksheet_REC = workbook.Sheets[4];
            Worksheet worksheet_TRACKPM = workbook.Sheets[5];
            Worksheet worksheet_TRACKOC = workbook.Sheets[6];
            Worksheet worksheet_TRACKREC = workbook.Sheets[7];

            int pm, oc, rec, totalPM, totalOC, totalREC, fila;
            string nroPM, nroOC, nroREC, origenPM, origenOC, origenREC, tipoTRACK;

            totalPM = worksheet_PM.Rows.Count;
            totalOC = worksheet_OC.Rows.Count;
            totalREC = worksheet_REC.Rows.Count;

            fila = 1;
            worksheet.Cells[fila, 1] = "NRO_PM";
            worksheet.Cells[fila, 2] = "NRO_OC";
            worksheet.Cells[fila, 3] = "NRO_REC";
            fila = 2;

            for (pm = 2; pm < totalPM; pm++)
            {
                nroPM = worksheet_PM.Cells[pm, 2].Value2;
                worksheet.Cells[fila, 1] = nroPM;

                for (oc = 2; oc < totalOC; oc++)
                {
                    nroOC = worksheet_TRACKOC.Cells[oc, 2].Value2;
                    tipoTRACK = worksheet_TRACKOC.Cells[oc, 3].Value2;
                    origenPM = worksheet_TRACKOC.Cells[oc, 8].Value2;

                    if (nroPM == origenPM)
                    {
                        worksheet_TRACKOC.Cells[fila, 2] = nroOC;

                        for (rec = 2; rec < totalREC; rec++)
                        {
                            nroREC = worksheet_TRACKREC.Cells[rec, 2].Value2;
                            tipoTRACK = worksheet_TRACKREC.Cells[rec, 3].Value2;
                            origenREC = worksheet_TRACKREC.Cells[rec, 8].Value2;

                            if (nroREC == origenREC)
                            {
                                worksheet.Cells[fila, 3] = nroREC;
                                fila++;
                            }
                            else
                                worksheet.Cells[fila, 3] = "PENDIENTE";

                            rec++;

                        }
                    }
                    else
                        worksheet.Cells[fila, 2] = "PENDIENTE";


                    oc++;
                }
                fila++;
                

                pm++;
            }

            miExcel.Quit();

        }
    }
}
