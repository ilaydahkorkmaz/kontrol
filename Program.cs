using System;

class Program
{
    static void Main()
    {
       
        string donus = "USER_BUSY";
        string donen = "bo�"; 

        
        if (donus == "USER_BUSY")
        {
            donen = "Me�gul";
        }
        if (donus == "ORIGINATOR_CANCEL")
        {
            donen = "Vazge�ildi";
        }
        if (donus == "NO_ANSWER")
        {
            donen = "Cevaps�z";
        }
        if (donus == "NORMAL_CLEARING")
        {
            donen = "Cevapland�";
        }
        if (donus == "CALL_REJECTED")
        {
            donen = "Reddedildi";
        }
        if (donus == "INCOMPATIBLE_DESTINATION")
        {
            donen = "Ses kodekleri uyumsuz";
        }
        if (donus == "INCOMING_CALL_BARRED")
        {
            donen = "Reddedildi";
        }
        if (donus == "UNALLOCATED_NUMBER")
        {
            donen = "Hatal� Numara";
        }
        if (donus == "NO_ROUTE_DESTINATION")
        {
            donen = "Hatal� Numara";
        }
        if (donus == "NO_USER_RESPONSE")
        {
            donen = "Ula��lam�yor";
        }
        if (donus == "NORMAL_UNSPECIFIED")
        {
            donen = "Cevapland�";
        }
        if (donus == "INVALID_NUMBER_FORMAT")
        {
            donen = "Hatal� Numara";
        }
        if (donus == "NOT_ALLOWED_BY_IYS")
        {
            donen = "�YS izni yok";
        }
        if (donus == "FACILITY_REJECTED")
        {
            donen = "Hata";
        }
        if (donus == "SERVICE_NOT_IMPLEMENTED")
        {
            donen = "Hata";
        }
        if (donus == "FACILITY_NOT_IMPLEMENTED")
        {
            donen = "Hata";
        }
        if (donus == "SERVICE_UNAVAILABLE")
        {
            donen = "Genel Hata";
        }
        if (donus == "INTERWORKING")
        {
            donen = "Genel Hata";
        }
        if (donus == "REDIRECTION_TO_NEW_DESTINATION")
        {
            donen = "Cihaz y�nlendirmesi";
        }
        if (donus == "EXCHANGE_ROUTING_ERROR")
        {
            donen = "�a�r� ba�lanamad�";
        }
        if (donus == "MEDIA_TIMEOUT")
        {
            donen = "RTP zamana��m�";
        }
        if (donus == "SYSTEM_SHUTDOWN")
        {
            donen = "Santral kapat�l�yor";
        }
        if (donus == "ATTENDED_TRANSFER")
        {
            donen = "Kat�l�ml� aktar�m";
        }
        if (donus == "PICKED_OFF")
        {
            donen = "�a�r�s� �ekildi";
        }
        if (donus == "DESTINATION_OUT_OF_ORDER")
        {
            donen = "Cihazla ileti�im sorunu";
        }
        if (donus == "NORMAL_TEMPORARY_FAILURE")
        {
            donen = "Cihazla ileti�im sorunu";
        }
        if (donus == "NETWORK_OUT_OF_ORDER")
        {
            donen = "�leti�im sorunu";
        }
        if (donus == "RECOVERY_ON_TIMER_EXPIRE")
        {
            donen = "Zamana��m�";
        }
        if (donus == "ALLOTTED_TIMEOUT")
        {
            donen = "Cevaps�z";
        }
        if (donus == "BEARERCAPABILITY_NOTIMPL")
        {
            donen = "Sesli g�r��me yapamayan numara";
        }
        if (donus == "LOSE_RACE")
        {
            donen = "Di�er dahili cevaplad�";
        }
        if (donus == "CHAN_NOT_IMPLEMENTED")
        {
            donen = "Desteklenmeyen kanal tipi";
        }
        if (donus == "NORMAL_CIRCUIT_CONGESTION")
        {
            donen = "Arama i�in santral uygun durumda de�il";
        }
        if (donus == "INVALID_CALL_REFERENCE")
        {
            donen = "Tan�nmayan �a�r� ID numaras�";
        }

        // Sonucu ekrana yazd�r
        Console.WriteLine($"Hata kodu: {donus}, A��klama: {donen}");
    }
}
