using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlagFinder.Models
{
    public class Flags : CollectionBase
    {
        public Flags()
        {
        }

        public List<Flag> FlagList()
        {
            List<Flag> flags = new List<Flag>();
            var flagColl = new Flags();
            flagColl.LoadFlags();
            foreach(Flag f in flagColl)
            {
                flags.Add(f);
            }
            return flags;
        }

        public void LoadFlags()
        {
            Add("Afghanistan", "", true, false, false, true, false, false, false, true, true, false, false, false, false, false, false, false, true, false, "flag-of-Afghanistan");
            Add("Albania", "", true, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, "flag-of-Albania");
            Add("Algeria", "", true, false, false, true, false, false, false, true, false, false, false, true, false, true, false, false, false, false, "flag-of-Algeria");
            Add("Andorra", "", true, false, true, false, true, false, false, true, false, false, false, false, false, false, false, false, true, false, "flag-of-Andorra");
            Add("Angola", "", true, false, true, false, false, false, false, false, true, false, false, true, false, false, false, false, false, true, "flag-of-Angola");
            Add("Antigua and Barbuda", "", true, false, true, false, true, false, false, true, true, false, true, false, true, false, false, false, false, false, "flag-of-Antigua");
            Add("Argentina", "", false, true, false, false, true, false, false, true, false, true, false, false, true, false, false, true, false, false, "flag-of-Argentina");
            Add("Armenia", "", true, true, false, false, true, false, false, false, false, false, false, false, false, false, false, true, false, false, "flag-of-Armenia");
            Add("Australia", "", true, false, false, false, true, false, false, true, false, false, true, true, false, false, true, false, false, false, "flag-of-Australia");
            Add("Austria", "", true, false, false, false, false, false, false, true, false, false, false, false, false, false, false, true, false, false, "flag-of-Austria");
            Add("Azerbaijan", "", true, false, false, true, true, false, false, true, false, false, false, true, false, true, false, true, false, false, "flag-of-Azerbaijan");
            Add("Bahamas", "", false, false, true, false, true, false, false, false, true, false, true, false, false, false, false, true, false, false, "flag-of-Bahamas");
            Add("Bahrain", "", true, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, "flag-of-Bahrain");
            Add("Bangladesh", "", true, false, false, true, false, false, false, false, false, true, false, false, false, false, false, false, false, false, "flag-of-Bangladesh");
            Add("Barbados", "", false, false, true, false, true, false, false, false, true, false, false, false, false, false, false, false, true, false, "flag-of-Barbados");
            Add("Belarus", "", true, false, false, true, false, false, false, true, false, false, false, false, false, false, false, false, false, true, "flag-of-Belarus");
            Add("Belgium", "", true, false, true, false, false, false, false, false, true, false, false, false, false, false, false, false, true, false, "flag-of-Belgium");
            Add("Belize", "", true, false, true, true, true, false, true, true, false, true, false, false, false, false, false, false, false, false, "flag-of-Belize");
            Add("Benin", "", true, false, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, true, "flag-of-Benin");
            Add("Bhutan", "", false, true, true, false, false, false, false, true, false, false, true, false, false, false, false, false, false, false, "flag-of-Bhutan");
            Add("Bolivia", "", true, true, true, true, true, false, true, false, false, false, false, false, false, false, false, true, false, false, "flag-of-Bolivia");
            Add("Bosnia and Herzegovina", "Bosnia", false, false, true, false, true, false, false, true, false, false, true, true, false, false, false, false, false, false, "flag-of-Bosnia-Herzegovina");
            Add("Botswana", "", false, false, false, false, true, false, false, true, true, false, false, false, false, false, false, false, false, false, "flag-of-Botswana");
            Add("Brazil", "", false, false, true, true, true, false, false, true, false, true, false, false, false, false, false, false, false, false, "flag-of-Brazil");
            Add("Brunei", "", true, false, true, false, false, false, false, true, true, false, true, false, false, false, false, false, false, false, "flag-of-Brunei");
            Add("Bulgaria", "", true, false, false, true, false, false, false, true, false, false, false, false, false, false, false, true, false, false, "flag-of-Bulgaria");
            Add("Burkina Faso", "", true, false, true, true, false, false, false, false, false, false, false, true, false, false, false, false, false, true, "flag-of-Burkina-Faso");
            Add("Burundi", "", true, false, false, true, false, false, false, true, false, true, true, true, false, false, false, false, false, false, "flag-of-Burundi");
            Add("Cabo Verde", "", true, false, true, false, true, false, false, true, false, false, false, true, false, false, false, false, false, false, "flag-of-Cabo-Verde");
            Add("Cambodia", "", true, false, false, false, true, false, false, true, false, false, false, false, false, false, false, true, false, false, "flag-of-Cambodia");
            Add("Cameroon", "", true, false, true, true, false, false, false, false, false, false, false, true, false, false, false, false, true, false, "flag-of-Cameroon");
            Add("Canada", "", true, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, true, false, "flag-of-Canada");
            Add("Central African Republic", "CAR", true, false, true, true, true, false, false, true, false, false, false, true, false, false, false, false, false, false, "flag-of-Central-African-Republic");
            Add("Chad", "", true, false, true, false, true, false, false, false, false, false, false, false, false, false, false, false, true, false, "flag-of-Chad");
            Add("Chile", "", true, false, false, false, true, false, false, true, false, false, false, true, false, false, false, false, false, true, "flag-of-Chile");
            Add("China", "", true, false, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, "flag-of-China");
            Add("Colombia", "", true, false, true, false, true, false, false, false, false, false, false, false, false, false, false, true, false, false, "flag-of-Colombia");
            Add("Comoros", "", true, false, true, true, true, false, false, true, false, false, true, true, false, true, false, false, false, false, "flag-of-Comoros");
            Add("Democratic Republic of the Congo", "DR Congo", true, false, true, false, true, false, false, false, false, false, true, true, false, false, false, false, false, false, "flag-of-Congo-Democratic-Republic-of");
            Add("Republic of the Congo", "Congo", true, false, true, true, false, false, false, false, false, false, true, false, false, false, false, false, false, false, "flag-of-Congo");
            Add("Costa Rica", "", true, false, true, true, true, false, false, true, false, false, false, false, false, false, false, false, false, false, "flag-of-Costa-Rica");
            Add("Cote d'Ivoire", "", false, true, false, true, false, false, false, true, false, false, false, false, false, false, false, false, true, false, "flag-of-Cote-d-Ivoire");
            Add("Croatia", "", true, false, true, false, true, false, false, true, false, false, false, false, false, false, false, true, false, false, "flag-of-Croatia");
            Add("Cuba", "", true, false, false, false, true, false, false, true, false, false, true, true, false, false, false, false, false, false, "flag-of-Cuba");
            Add("Cyprus", "", false, false, true, true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, "flag-of-Cyprus");
            Add("Czech Republic", "", true, false, false, false, true, false, false, true, false, false, true, false, false, false, false, false, false, true, "flag-of-Czech-Republic");
            Add("Denmark", "", true, false, false, false, false, false, false, true, false, false, false, false, false, false, true, false, false, false, "flag-of-Denmark");
            Add("Djibouti", "", true, false, false, true, true, false, false, true, false, false, true, true, false, false, false, false, false, true, "flag-of-Djibouti");
            Add("Dominica", "", true, false, true, true, false, true, true, true, true, true, false, true, false, false, true, false, false, false, "flag-of-Dominica");
            Add("Dominican Republic", "", true, false, false, true, true, false, false, true, false, false, false, false, false, false, true, false, false, false, "flag-of-Dominican-Republic");
            Add("Ecuador", "", true, false, true, true, true, false, true, true, false, false, false, false, false, false, false, true, false, false, "flag-of-Ecuador");
            Add("Egypt", "", true, false, true, false, false, false, false, true, true, false, false, false, false, false, false, true, false, false, "flag-of-Egypt");
            Add("El Salvador", "", true, true, true, true, true, false, false, true, false, false, false, false, false, false, false, true, false, false, "flag-of-El-Salvador");
            Add("Equatorial Guinea", "", true, false, true, true, true, false, false, true, false, false, true, false, false, false, false, true, false, false, "flag-of-Equatorial-Guinea");
            Add("Eritrea", "", true, false, true, true, true, false, false, false, false, false, true, false, false, false, false, false, false, false, "flag-of-Eritrea");
            Add("Estonia", "", false, false, false, false, true, false, false, true, true, false, false, false, false, false, false, true, false, false, "flag-of-Estonia");
            Add("Ethiopia", "", true, false, true, true, true, false, false, false, false, true, true, true, false, false, false, true, false, false, "flag-of-Ethiopia");
            Add("Fiji", "", true, false, true, true, true, false, true, true, false, false, true, false, false, false, true, false, false, false, "flag-of-Fiji");
            Add("Finland", "", false, false, false, false, true, false, false, true, false, false, false, false, false, false, true, false, false, false, "flag-of-Finland");
            Add("France", "", true, false, false, false, true, false, false, true, false, false, false, false, false, false, false, false, true, false, "flag-of-France");
            Add("Gabon", "", false, false, true, true, true, false, false, false, false, false, false, false, false, false, false, true, false, false, "flag-of-Gabon");
            Add("Gambia", "", true, false, false, true, true, false, false, true, false, false, false, false, false, false, false, false, false, false, "flag-of-Gambia");
            Add("Georgia", "", true, false, false, false, false, false, false, true, false, false, false, false, false, false, true, false, false, false, "flag-of-Georgia");
            Add("Germany", "", true, false, true, false, false, false, false, false, true, false, false, false, false, false, false, true, false, false, "flag-of-Germany");
            Add("Ghana", "", true, false, true, true, false, false, false, false, true, false, false, true, false, false, false, true, false, false, "flag-of-Ghana");
            Add("Greece", "", false, false, false, false, true, false, false, true, false, false, false, false, false, false, true, false, false, false, "flag-of-Greece");
            Add("Grenada", "", true, false, true, true, false, false, false, false, false, true, true, true, false, false, false, false, false, false, "flag-of-Grenada");
            Add("Guatemala", "", false, false, true, true, true, false, true, true, false, false, false, false, false, false, false, false, true, false, "flag-of-Guatemala");
            Add("Guinea", "", true, false, true, true, false, false, false, false, false, false, false, false, false, false, false, false, true, false, "flag-of-Guinea");
            Add("Guinea-Bissau", "", true, false, true, true, false, false, false, false, true, false, false, true, false, false, false, false, false, true, "flag-of-Guinea-Bissau");
            Add("Guyana", "", true, false, true, true, false, false, false, true, true, false, true, false, false, false, false, false, false, false, "flag-of-Guyana");
            Add("Haiti", "", true, false, true, true, true, false, false, true, false, false, false, false, false, false, false, false, false, true, "flag-of-Haiti");
            Add("Honduras", "", false, false, false, false, true, false, false, true, false, false, false, true, false, false, false, true, false, false, "flag-of-Honduras");
            Add("Hungary", "", true, false, false, true, false, false, false, true, false, false, false, false, false, false, false, true, false, false, "flag-of-Hungary");
            Add("Iceland", "", true, false, false, false, true, false, false, true, false, false, false, false, false, false, true, false, false, false, "flag-of-Iceland");
            Add("India", "", false, true, false, true, true, false, false, true, false, true, false, false, false, false, false, true, false, false, "flag-of-India");
            Add("Indonesia", "", true, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, true, "flag-of-Indonesia");
            Add("Iran", "", true, false, false, true, false, false, false, true, false, false, false, false, false, false, false, true, false, false, "flag-of-Iran");
            Add("Iraq", "", true, false, false, true, false, false, false, true, true, false, false, false, false, false, false, true, false, false, "flag-of-Iraq");
            Add("Ireland", "", false, true, false, true, false, false, false, true, false, false, false, false, false, false, false, false, true, false, "flag-of-Ireland");
            Add("Israel", "", false, false, false, false, true, false, false, true, false, false, true, true, false, false, false, false, false, false, "flag-of-Israel");
            Add("Italy", "", true, false, false, true, false, false, false, true, false, false, false, false, false, false, false, false, true, false, "flag-of-Italy");
            Add("Jamaica", "", false, false, true, true, false, false, false, false, true, false, true, false, false, false, false, false, false, false, "flag-of-Jamaica");
            Add("Japan", "", true, false, false, false, false, false, false, true, false, true, false, false, false, false, false, false, false, false, "flag-of-Japan");
            Add("Jordan", "", true, false, false, true, false, false, false, true, true, false, true, true, false, false, false, true, false, false, "flag-of-Jordan");
            Add("Kazakhstan", "", false, false, true, false, true, false, false, false, false, true, false, false, true, false, false, false, false, false, "flag-of-Kazakhstan");
            Add("Kenya", "", true, false, false, true, false, false, false, true, true, false, false, false, false, false, false, false, false, false, "flag-of-Kenya");
            Add("Kiribati", "", true, false, true, false, true, false, false, true, false, false, false, false, true, false, false, false, false, false, "flag-of-Kiribati");
            Add("Kosovo", "", false, false, true, false, true, false, false, true, false, false, false, true, false, false, false, false, false, false, "flag-of-Kosovo");
            Add("Kuwait", "", true, false, false, true, false, false, false, true, true, false, false, false, false, false, false, true, false, false, "flag-of-Kuwait");
            Add("Kyrgyzstan", "", true, false, true, false, false, false, false, false, false, true, false, false, true, false, false, false, false, false, "flag-of-Kyrgyzstan");
            Add("Laos", "", true, false, false, false, true, false, false, true, false, true, false, false, false, false, false, true, false, false, "flag-of-Laos");
            Add("Latvia", "", true, false, false, false, false, false, false, true, false, false, false, false, false, false, false, true, false, false, "flag-of-Latvia");
            Add("Lebanon", "", true, false, false, true, false, false, false, true, false, false, false, false, false, false, false, true, false, false, "flag-of-Lebanon");
            Add("Lesotho", "", false, false, false, true, true, false, false, true, true, false, false, false, false, false, false, true, false, false, "flag-of-Lesotho");
            Add("Liberia", "", true, false, false, false, true, false, false, true, false, false, false, true, false, false, false, false, false, false, "flag-of-Liberia");
            Add("Libya", "", true, false, false, true, false, false, false, true, true, false, false, true, false, true, false, true, false, false, "flag-of-Libya");
            Add("Liechtenstein", "", true, false, true, false, true, false, false, false, true, false, false, false, false, false, false, false, false, true, "flag-of-Liechtenstein");
            Add("Lithuania", "", true, false, true, true, false, false, false, false, false, false, false, false, false, false, false, true, false, false, "flag-of-Lithuania");
            Add("Luxembourg", "", true, false, false, false, true, false, false, true, false, false, false, false, false, false, false, true, false, false, "flag-of-Luxembourg");
            Add("Macedonia (FYROM)", "", true, false, true, false, false, false, false, false, false, true, true, false, true, false, false, false, false, false, "flag-of-Macedonia");
            Add("Madagascar", "", true, false, false, true, false, false, false, true, false, false, false, false, false, false, false, false, false, true, "flag-of-Madagascar");
            Add("Malawi", "", true, false, false, true, false, false, false, false, true, false, false, false, true, false, false, true, false, false, "flag-of-Malawi");
            Add("Malaysia", "", true, false, true, false, true, false, false, true, false, false, false, false, true, true, false, false, false, false, "flag-of-Malaysia");
            Add("Maldives", "", true, false, false, true, false, false, false, true, false, false, false, false, false, true, false, false, false, false, "flag-of-Maldives");
            Add("Mali", "", true, false, true, true, false, false, false, false, false, false, false, false, false, false, false, false, true, false, "flag-of-Mali");
            Add("Malta", "", true, false, false, false, false, false, false, true, false, false, false, false, false, false, true, false, false, false, "flag-of-Malta");
            Add("Marshall Islands", "", false, true, false, false, true, false, false, true, false, false, true, true, false, false, false, false, false, false, "flag-of-Marshall-Islands");
            Add("Mauritania", "", false, false, true, true, false, false, false, false, false, false, false, true, false, true, false, false, false, false, "flag-of-Mauritania");
            Add("Mauritius", "", true, false, true, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, "flag-of-Mauritius");
            Add("Mexico", "", true, true, true, true, true, false, true, true, false, false, false, false, false, false, false, false, true, false, "flag-of-Mexico");
            Add("Micronesia", "", false, false, false, false, true, false, false, true, false, false, false, true, false, false, false, false, false, false, "flag-of-Micronesia");
            Add("Moldova", "", true, false, true, true, true, false, true, false, false, false, false, false, false, false, false, false, true, false, "flag-of-Moldova");
            Add("Monaco", "", true, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, true, "flag-of-Monaco");
            Add("Mongolia", "", true, false, true, false, true, false, false, false, false, true, true, false, false, false, false, false, true, false, "flag-of-Mongolia");
            Add("Montenegro", "", true, false, true, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, "flag-of-Montenegro");
            Add("Morocco", "", true, false, false, true, false, false, false, false, false, false, true, true, false, false, false, false, false, false, "flag-of-Morocco");
            Add("Mozambique", "", true, false, true, true, false, false, false, true, true, false, true, true, false, false, false, false, false, false, "flag-of-Mozambique");
            Add("Myanmar (Burma)", "", true, false, true, true, false, false, false, true, false, false, false, true, false, false, false, true, false, false, "flag-of-Myanmar");
            Add("Namibia", "", true, false, true, true, false, false, false, true, false, true, true, false, true, false, false, false, false, false, "flag-of-Namibia");
            Add("Nauru", "", false, false, true, false, true, false, false, true, false, false, false, true, true, false, false, false, false, false, "flag-of-Nauru");
            Add("Nepal", "", true, false, false, false, true, false, false, true, false, false, false, true, true, false, false, false, false, false, "flag-of-Nepal");
            Add("Netherlands", "", true, false, false, false, true, false, false, true, false, false, false, false, false, false, false, true, false, false, "flag-of-Netherlands");
            Add("New Zealand", "", true, false, false, false, true, false, false, true, false, false, true, true, false, false, true, false, false, false, "flag-of-New-Zealand");
            Add("Nicaragua", "", true, true, true, true, true, false, false, true, false, true, true, false, false, false, false, true, false, false, "flag-of-Nicaragua");
            Add("Niger", "", false, true, false, true, false, false, false, true, false, true, false, false, false, false, false, true, false, false, "flag-of-Niger");
            Add("Nigeria", "", false, false, false, true, false, false, false, true, false, false, false, false, false, false, false, false, true, false, "flag-of-Nigeria");
            Add("North Korea", "", true, false, false, false, true, false, false, true, false, true, false, true, false, false, false, false, false, false, "flag-of-Korea-North");
            Add("Norway", "", true, false, false, false, true, false, false, true, false, false, false, false, false, false, true, false, false, false, "flag-of-Norway");
            Add("Oman", "", true, false, false, true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, "flag-of-Oman");
            Add("Pakistan", "", false, false, false, true, false, false, false, true, false, false, false, true, false, true, false, false, false, false, "flag-of-Pakistan");
            Add("Palau", "", false, false, true, false, true, false, false, false, false, true, false, false, false, false, false, false, false, false, "flag-of-Palau");
            Add("Palestine", "", true, false, false, true, false, false, false, true, true, false, true, false, false, false, false, true, false, false, "flag-of-Palestine");
            Add("Panama", "", true, false, false, false, true, false, false, true, false, false, false, true, false, false, false, false, false, false, "flag-of-Panama");
            Add("Papua New Guinea", "", true, false, true, false, false, false, false, true, true, false, true, true, false, false, false, false, false, false, "flag-of-Papua-New-Guinea");
            Add("Paraguay", "", true, false, true, true, true, false, false, true, true, true, false, false, false, false, false, true, false, false, "flag-of-Paraguay");
            Add("Peru", "", true, false, true, true, false, false, false, true, false, false, false, false, false, false, false, false, true, false, "flag-of-Peru");
            Add("Philippines", "", true, false, true, false, true, false, false, true, false, true, true, true, true, false, false, false, false, true, "flag-of-Philippines");
            Add("Poland", "", true, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, true, "flag-of-Poland");
            Add("Portugal", "", true, false, true, true, true, false, false, true, false, true, false, false, false, false, false, false, false, false, "flag-of-Portugal");
            Add("Qatar", "", true, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, "flag-of-Qatar");
            Add("Romania", "", true, false, true, false, true, false, false, false, false, false, false, false, false, false, false, false, true, false, "flag-of-Romania");
            Add("Russia", "", true, false, false, false, true, false, false, true, false, false, false, false, false, false, false, true, false, false, "flag-of-Russia");
            Add("Rwanda", "", false, false, true, true, true, false, false, false, false, true, false, false, true, false, false, true, false, false, "flag-of-Rwanda");
            Add("Saint Kitts and Nevis", "St Kitts & Nevis", true, false, true, true, false, false, false, true, true, false, true, true, false, false, false, false, false, false, "flag-of-St-Kitts-Nevis");
            Add("Saint Lucia", "", false, false, true, false, true, false, false, true, true, false, true, false, false, false, false, false, false, false, "flag-of-St-Lucia");
            Add("Saint Vincent and the Grenadines", "St Vincent", false, false, true, true, true, false, false, false, false, false, false, false, false, false, false, false, true, false, "flag-of-St-Vincent-the-Grenadines");
            Add("Samoa", "", true, false, false, false, true, false, false, true, false, false, false, true, false, false, false, false, false, false, "flag-of-Samoa");
            Add("San Marino", "", false, false, true, true, true, false, false, true, false, false, false, false, false, false, false, false, false, true, "flag-of-San-Marino");
            Add("Sao Tome and Principe", "Sao Tome & Principe", true, false, true, true, false, false, false, false, true, false, true, true, false, false, false, true, false, false, "flag-of-Sao-Tome-Principe");
            Add("Saudi Arabia", "", false, false, false, true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, "flag-of-Saudi-Arabia");
            Add("Senegal", "", true, false, true, true, false, false, false, false, false, false, false, true, false, false, false, false, true, false, "flag-of-Senegal");
            Add("Serbia", "", true, false, true, false, true, false, false, true, false, false, false, false, false, false, false, true, false, false, "flag-of-Serbia");
            Add("Seychelles", "", true, false, true, true, true, false, false, true, false, false, true, false, false, false, false, false, false, false, "flag-of-Seychelles");
            Add("Sierra Leone", "", false, false, false, true, true, false, false, true, false, false, false, false, false, false, false, true, false, false, "flag-of-Sierra-Leone");
            Add("Singapore", "", true, false, false, false, false, false, false, true, false, false, false, true, false, true, false, false, false, true, "flag-of-Singapore");
            Add("Slovakia", "", true, false, false, false, true, false, false, true, false, false, false, false, false, false, true, true, false, false, "flag-of-Slovakia");
            Add("Slovenia", "", true, false, true, false, true, false, false, true, false, false, false, true, false, false, false, true, false, false, "flag-of-Slovenia");
            Add("Solomon Islands", "", false, false, true, true, true, false, false, true, false, false, true, true, false, false, false, false, false, false, "flag-of-Solomon-Islands");
            Add("Somalia", "", false, false, false, false, true, false, false, true, false, false, false, true, false, false, false, false, false, false, "flag-of-Somalia");
            Add("South Africa", "", true, false, true, true, true, false, false, true, true, false, true, false, false, false, false, false, false, false, "flag-of-South-Africa");
            Add("South Korea", "", true, false, false, false, true, false, false, true, true, true, false, false, false, false, false, false, false, false, "flag-of-Korea-South");
            Add("South Sudan", "", true, false, true, true, true, false, false, true, true, false, true, true, false, false, false, true, false, false, "flag-of-South-Sudan");
            Add("Spain", "", true, false, true, true, true, false, false, true, false, false, false, false, false, false, false, true, false, false, "flag-of-Spain");
            Add("Sri Lanka", "", true, true, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, "flag-of-Sri-Lanka");
            Add("Sudan", "", true, false, false, true, false, false, false, true, true, false, true, false, false, false, false, true, false, false, "flag-of-Sudan");
            Add("Suriname", "", true, false, true, true, false, false, false, true, false, false, false, true, false, false, false, false, false, false, "flag-of-Suriname");
            Add("Swaziland", "", true, false, true, false, true, false, false, true, true, false, false, false, false, false, false, false, false, false, "flag-of-Swaziland");
            Add("Sweden", "", false, false, true, false, true, false, false, false, false, false, false, false, false, false, true, false, false, false, "flag-of-Sweden");
            Add("Switzerland", "", true, false, false, false, false, false, false, true, false, false, false, false, false, false, true, false, false, false, "flag-of-Switzerland");
            Add("Syria", "", true, false, false, true, false, false, false, true, true, false, false, true, false, false, false, true, false, false, "flag-of-Syria");
            Add("Taiwan", "", true, false, false, false, true, false, false, true, false, true, false, false, true, false, false, false, false, false, "flag-of-Taiwan");
            Add("Tajikistan", "", true, false, true, true, false, false, false, true, false, false, false, true, false, false, false, true, false, false, "flag-of-Tajikistan");
            Add("Tanzania", "", false, false, true, true, true, false, false, false, true, false, true, false, false, false, false, false, false, false, "flag-of-Tanzania");
            Add("Thailand", "", true, false, false, false, true, false, false, true, false, false, false, false, false, false, false, false, false, false, "flag-of-Thailand");
            Add("Timor-Leste", "", true, false, true, false, false, false, false, true, true, false, true, true, false, false, false, false, false, false, "flag-of-Timor-Leste");
            Add("Togo", "", true, false, true, true, false, false, false, true, false, false, false, true, false, false, false, false, false, false, "flag-of-Togo");
            Add("Tonga", "", true, false, false, false, false, false, false, true, false, false, false, false, false, false, true, false, false, false, "flag-of-Tonga");
            Add("Trinidad and Tobago", "", true, false, false, false, false, false, false, true, true, false, true, false, false, false, false, false, false, false, "flag-of-Trinidad-Tobago");
            Add("Tunisia", "", true, false, false, false, false, false, false, true, false, true, false, true, false, true, false, false, false, false, "flag-of-Tunisia");
            Add("Turkey", "", true, false, false, false, false, false, false, true, false, false, false, true, false, true, false, false, false, false, "flag-of-Turkey");
            Add("Turkmenistan", "", true, false, true, true, false, false, false, true, false, false, false, true, false, true, false, false, false, false, "flag-of-Turkmenistan");
            Add("Tuvalu", "", true, false, true, false, true, false, false, true, false, false, true, true, false, false, true, false, false, false, "flag-of-Tuvalu");
            Add("Uganda", "", true, false, true, false, false, false, false, true, true, true, false, false, false, false, false, false, false, false, "flag-of-Uganda");
            Add("Ukraine", "", false, false, true, false, true, false, false, false, false, false, false, false, false, false, false, false, false, true, "flag-of-Ukraine");
            Add("United Arab Emirates", "Emirates", true, false, false, true, false, false, false, true, true, false, false, false, false, false, false, true, false, false, "flag-of-United-Arab-Emirates");
            Add("United Kingdom", "", true, false, false, false, true, false, false, true, false, false, true, false, false, false, true, false, false, false, "flag-of-United-Kingdom");
            Add("United States of America", "USA", true, false, false, false, true, false, false, true, false, false, false, true, false, false, false, false, false, false, "flag-of-United-States-of-America");
            Add("Uruguay", "", false, false, true, false, true, false, false, true, false, false, false, false, true, false, false, false, false, false, "flag-of-Uruguay");
            Add("Uzbekistan", "", true, false, false, true, true, false, false, true, false, false, false, true, false, true, false, false, false, false, "flag-of-Uzbekistan");
            Add("Vanuatu", "", true, false, true, true, false, false, false, false, true, false, true, false, false, false, false, false, false, false, "flag-of-Vanuatu");
            Add("Vatican City (Holy See)", "Vatican City", true, false, true, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, "flag-of-Vatican-City");
            Add("Venezuela", "", true, false, true, false, true, false, false, true, false, false, false, true, false, false, false, true, false, false, "flag-of-Venezuela");
            Add("Vietnam", "", true, false, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, "flag-of-Vietnam");
            Add("Yemen", "", true, false, false, false, false, false, false, true, true, false, false, false, false, false, false, true, false, false, "flag-of-Yemen");
            Add("Zambia", "", true, true, false, true, false, false, false, false, true, false, false, false, false, false, false, false, false, false, "flag-of-Zambia");
            Add("Zimbabwe", "", true, false, true, true, false, false, false, true, true, false, true, true, false, false, false, false, false, false, "flag-of-Zimbabwe");
        }

        void Add(string name, string shortName, bool red, bool orange, bool yellow, bool green, bool blue, bool purple, bool brown, bool white, bool black,
            bool circle, bool triangle, bool star, bool sun, bool moon, bool cross, bool triColorHorz, bool triColorVert, bool biColorHorz, string imgName)
        {
            Flag flag = new Flag();
            flag.ShortName = shortName;
            flag.Name = name;
            flag.Red = red;
            flag.Orange = orange;
            flag.Yellow = yellow;
            flag.Green = green;
            flag.Blue = blue;
            flag.Purple = purple;
            flag.Brown = brown;
            flag.White = white;
            flag.Black = black;
            flag.Circle = circle;
            flag.Triangle = triangle;
            flag.Star = star;
            flag.Sun = sun;
            flag.Moon = moon;
            flag.Cross = cross;
            flag.TriColorHorizontal = triColorHorz;
            flag.TriColorVertical = triColorVert;
            flag.BiColorHorizontal = biColorHorz;
            flag.ImageLocation = "/Content/Images/" + imgName + ".png";
            List.Add(flag);
        }

    }
}
