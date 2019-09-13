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
            //declaracion de arreglos
            string[,] tracking;
            tracking = new string[4000,3];

            //declaracion de variables de Excel
            Application miExcel = new Application();
            miExcel.Visible = false;
            Workbook workbook = miExcel.Workbooks.Open(dirArchivo);
            Worksheet worksheet = workbook.Sheets[1];
            Worksheet worksheet_PM = workbook.Sheets[2];
            Worksheet worksheet_OC = workbook.Sheets[3];
            Worksheet worksheet_REC = workbook.Sheets[4];
            Worksheet worksheet_TRACK = workbook.Sheets[5];

            int pm, oc, rec, track, totalPM, totalOC, totalREC, totalTRACK, fila;
            int contOC, contREC;
            string nroPM, nroOC, nroREC, origenPM, origenOC, origenREC, tipoTRACK;

            totalPM = worksheet_PM.UsedRange.Rows.Count;
            totalOC = worksheet_OC.UsedRange.Rows.Count;
            totalREC = worksheet_REC.UsedRange.Rows.Count;
            totalTRACK = worksheet_TRACK.UsedRange.Rows.Count;

            System.Console.Out.WriteLine(totalPM);
            System.Console.Out.WriteLine(totalOC);
            System.Console.Out.WriteLine(totalREC);

            fila = 0;
            tracking[0, 0] = "NRO_PM";
            tracking[0, 1] = "NRO_OC";
            tracking[0, 2] = "NRO_REC";
            fila = 1;

            for (pm = 2; pm < totalPM; pm++)
            {
                nroPM = (string)worksheet_PM.Cells[pm, 2].Value2;
                contOC = 0;

                for (track = 2; track < totalTRACK; track++)
                {
                    nroOC = (string)worksheet_TRACK.Cells[track, 2].Value2;
                    tipoTRACK = (string)worksheet_TRACK.Cells[track, 3].Value2;
                    origenPM = (string)worksheet_TRACK.Cells[track, 8].Value2;

                    if (string.Equals(nroPM, origenPM) && string.Equals(tipoTRACK,"Orden de Compra"))
                    {

                        tracking[fila, 0] = nroPM;
                        tracking[fila, 1] = nroOC;
                        System.Console.Out.WriteLine("nroPM: " + tracking[fila,0] + " " + "nroOC: " + tracking[fila,1]);
                        fila++;
                    }

                    contOC++;
                    if (contOC > 31)
                    {
                        break;
                    }
                }
            }

            workbook.Save();
            workbook.Close();
            miExcel.Quit();

        }
    }
}
