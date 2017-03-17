using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TFT
{
    public class TFT
    {
        //Create Standalone SDK class dynamicly.
        public static zkemkeeper.CZKEM axCZKEM1 = new zkemkeeper.CZKEM();

        private static bool bIsConnected = false;//the boolean value identifies whether the device is connected
        private static int iMachineNumber = 1;//the serial number of the device.After connecting the device ,this value will be changed.

        public static Response conectar(string ip, int puerto)
        {

            Response result = new Response();

            int idwErrorCode = 0;

            bIsConnected = axCZKEM1.Connect_Net(ip, Convert.ToInt32(puerto));
            if (bIsConnected == true)
            {
                iMachineNumber = 1;//In fact,when you are using the tcp/ip communication,this parameter will be ignored,that is any integer will all right.Here we use 1.
                axCZKEM1.RegEvent(iMachineNumber, 65535);//Here you can register the realtime events that you want to be triggered(the parameters 65535 means registering all)

                result.status = Estatus.OK;
                result.resultado = "Conectado";

            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);
                result.status = Estatus.ERROR;
                result.error = "Unable to connect the device, ErrorCode=" + idwErrorCode.ToString();
            }

            return result;
        }


        public static Response desConectar()
        {
            Response result = new Response();

            if(bIsConnected)
                axCZKEM1.Disconnect();
            
            result.status = Estatus.OK;

            return result;
        }


        public static List<AttLogs> obtieneChecadas()
        {
            List<AttLogs> result = new List<AttLogs>();
            AttLogs ent;

            string sdwEnrollNumber = "";

            int idwVerifyMode = 0;
            int idwInOutMode = 0;
            int idwYear = 0;
            int idwMonth = 0;
            int idwDay = 0;
            int idwHour = 0;
            int idwMinute = 0;
            int idwSecond = 0;
            int idwWorkcode = 0;

            int idwErrorCode = 0;

            axCZKEM1.EnableDevice(iMachineNumber, false); // disable the device

            if (axCZKEM1.ReadGeneralLogData(iMachineNumber)) // read all the attendance records to the memory
            {
                while (axCZKEM1.SSR_GetGeneralLogData(iMachineNumber, out sdwEnrollNumber, out idwVerifyMode,
                           out idwInOutMode, out idwYear, out idwMonth, out idwDay, out idwHour, out idwMinute, out idwSecond, ref idwWorkcode))//get records from the memory
                {
                    ent = new AttLogs();

                    ent.enrolIdNumber = Convert.ToInt16(sdwEnrollNumber);

                    string fecha = 
                        idwYear.ToString() + "-" + 
                        idwMonth.ToString() + "-" + 
                        idwDay.ToString() + " " + 
                        idwHour.ToString() + ":" + 
                        idwMinute.ToString();

                    ent.fecha = Convert.ToDateTime(fecha);

                    result.Add(ent);
                }
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);

                if (idwErrorCode != 0)
                {
                    throw new Exception("Lectura de información del checador falló. ErrorCode: " + idwErrorCode.ToString());
                }
                else
                {
                    throw new Exception("No hay informacion en el Checador");
                }
            }

            axCZKEM1.EnableDevice(iMachineNumber, true);//enable the device

            return result;
        }
    }
}
