using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKARCAFE.Core.Shared
{
    public static class GlobalDatas
    {
        private static int? mKullaniciId;
        public static int? pKullaniciId
        {
            get
            {
                return mKullaniciId;
            }
            set
            {
                mKullaniciId = value;
            }
        }

        // ******************************************************************************** //

        private static string mKullaniciAdi;
        public static string pKullaniciAdi
        {
            get
            {
                return mKullaniciAdi;
            }
            set
            {
                mKullaniciAdi = value;
            }
        }

        // ******************************************************************************** //

        private static string mSifre;
        public static string pSifre
        {
            get
            {
                return mSifre;
            }
            set
            {
                mSifre = value;
            }
        }

        // ******************************************************************************** //

        private static string mKullaniciAdiSoyadi;
        public static string pKullaniciAdiSoyadi
        {
            get
            {
                return mKullaniciAdiSoyadi;
            }
            set
            {
                mKullaniciAdiSoyadi = value;
            }
        }

        // ******************************************************************************** //

        private static string mBilgisayarIpAdresi;
        public static string pBilgisayarIpAdresi
        {
            get
            {
                return mBilgisayarIpAdresi;
            }
            set
            {
                mBilgisayarIpAdresi = value;
            }
        }

        // ******************************************************************************** //

        private static string mSubeKodu;
        public static string pSubeKodu
        {
            get
            {
                return mSubeKodu;
            }
            set
            {
                mSubeKodu = value;
            }
        }

        // ******************************************************************************** //

        private static string mSubeAdi;
        public static string pSubeAdi
        {
            get
            {
                return mSubeAdi;
            }
            set
            {
                mSubeAdi = value;
            }
        }

        // ******************************************************************************** //

        private static string mEmail;
        public static string pEmail
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }

        // ******************************************************************************** //

    }
}
