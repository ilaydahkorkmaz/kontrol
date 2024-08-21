using System;

class Program
{
    static void Main()
    {
       
        string donus = "USER_BUSY";
        string donen = "boþ"; 

        
        if (donus == "USER_BUSY")
        {
            donen = "Meþgul";
        }
        if (donus == "ORIGINATOR_CANCEL")
        {
            donen = "Vazgeçildi";
        }
        if (donus == "NO_ANSWER")
        {
            donen = "Cevapsýz";
        }
        if (donus == "NORMAL_CLEARING")
        {
            donen = "Cevaplandý";
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
            donen = "Hatalý Numara";
        }
        if (donus == "NO_ROUTE_DESTINATION")
        {
            donen = "Hatalý Numara";
        }
        if (donus == "NO_USER_RESPONSE")
        {
            donen = "Ulaþýlamýyor";
        }
        if (donus == "NORMAL_UNSPECIFIED")
        {
            donen = "Cevaplandý";
        }
        if (donus == "INVALID_NUMBER_FORMAT")
        {
            donen = "Hatalý Numara";
        }
        if (donus == "NOT_ALLOWED_BY_IYS")
        {
            donen = "ÝYS izni yok";
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
            donen = "Cihaz yönlendirmesi";
        }
        if (donus == "EXCHANGE_ROUTING_ERROR")
        {
            donen = "Çaðrý baðlanamadý";
        }
        if (donus == "MEDIA_TIMEOUT")
        {
            donen = "RTP zamanaþýmý";
        }
        if (donus == "SYSTEM_SHUTDOWN")
        {
            donen = "Santral kapatýlýyor";
        }
        if (donus == "ATTENDED_TRANSFER")
        {
            donen = "Katýlýmlý aktarým";
        }
        if (donus == "PICKED_OFF")
        {
            donen = "Çaðrýsý çekildi";
        }
        if (donus == "DESTINATION_OUT_OF_ORDER")
        {
            donen = "Cihazla iletiþim sorunu";
        }
        if (donus == "NORMAL_TEMPORARY_FAILURE")
        {
            donen = "Cihazla iletiþim sorunu";
        }
        if (donus == "NETWORK_OUT_OF_ORDER")
        {
            donen = "Ýletiþim sorunu";
        }
        if (donus == "RECOVERY_ON_TIMER_EXPIRE")
        {
            donen = "Zamanaþýmý";
        }
        if (donus == "ALLOTTED_TIMEOUT")
        {
            donen = "Cevapsýz";
        }
        if (donus == "BEARERCAPABILITY_NOTIMPL")
        {
            donen = "Sesli görüþme yapamayan numara";
        }
        if (donus == "LOSE_RACE")
        {
            donen = "Diðer dahili cevapladý";
        }
        if (donus == "CHAN_NOT_IMPLEMENTED")
        {
            donen = "Desteklenmeyen kanal tipi";
        }
        if (donus == "NORMAL_CIRCUIT_CONGESTION")
        {
            donen = "Arama için santral uygun durumda deðil";
        }
        if (donus == "INVALID_CALL_REFERENCE")
        {
            donen = "Tanýnmayan Çaðrý ID numarasý";
        }

        // Sonucu ekrana yazdýr
        Console.WriteLine($"Hata kodu: {donus}, Açýklama: {donen}");
    }
}
