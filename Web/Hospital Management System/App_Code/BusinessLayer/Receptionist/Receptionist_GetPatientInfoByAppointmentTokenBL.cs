﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Summary description for GetPatientInfoByAppointmentTokenBL
/// </summary>
public class GetPatientInfoByAppointmentTokenBL
{
	public DataSet GetPatientInfoByAppointmentToken(string appointmentToken)
	{
        GetPatientInfoByAppointmentTokenDL objGetPatientInfoByAppointmentTokenDL = new GetPatientInfoByAppointmentTokenDL();
        return objGetPatientInfoByAppointmentTokenDL.GetPatientInfoByAppointmentToken(appointmentToken);
	}
}