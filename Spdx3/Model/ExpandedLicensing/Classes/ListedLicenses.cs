using System.Globalization;
using Spdx3.Model.Core.Classes;
using Spdx3.Utility;

namespace Spdx3.Model.ExpandedLicensing.Classes;

public class ListedLicenses
{
    private static readonly CreationInfo _creationInfo = new CreationInfo(
        new Catalog() ,
        DateTimeOffset.ParseExact("2025-05-18T03:08:51.0713280+00:00", "o", new DateTimeFormatInfo())
    )
    { SpdxId = new Uri("https://github.com/mharrah/Spdx3/ListedListedLicenses") }
    ;


    public static readonly ListedLicense BSD_SOURCE_BEGINNING_FILE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/BSD-Source-beginning-file"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/lattera/freebsd/blob/master/sys/cam/cam.c#L4")
        ],
        LicenseText = ReadResource("BSD-Source-beginning-file.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("BSD-Source-beginning-file.template.txt"),
        Comment = "This license is mostly the same as BSD-Source-Code but adds includes a specific requirement requiring retention of the copyright notice \"immediately at the beginning of the file\".",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BSD_3_CLAUSE_NO_NUCLEAR_LICENSE_2014 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/BSD-3-Clause-No-Nuclear-License-2014"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://java.net/projects/javaeetutorial/pages/BerkeleyLicense")
        ],
        LicenseText = ReadResource("BSD-3-Clause-No-Nuclear-License-2014.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("BSD-3-Clause-No-Nuclear-License-2014.template.txt"),
        Comment = "This license has a Oracle copyright notice. It is the same license as BSD-3-Clause-No-Nuclear-License, except it has a different entire disclaimer clause that is the same as BSD-3-Clause.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GD = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GD"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://libgd.github.io/manuals/2.3.0/files/license-txt.html")
        ],
        LicenseText = ReadResource("GD.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GD.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_NC_4_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-NC-4.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by-nc/4.0/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-NC-4.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-NC-4.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense NICTA_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/NICTA-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.apple.com/source/mDNSResponder/mDNSResponder-320.10/mDNSPosix/nss_ReadMe.txt")
        ],
        LicenseText = ReadResource("NICTA-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("NICTA-1.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense MS_RL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/MS-RL"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.microsoft.com/opensource/licenses.mspx"),
            new Uri("https://opensource.org/licenses/MS-RL")
        ],
        LicenseText = ReadResource("MS-RL.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("MS-RL.template.txt"),
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense METAMAIL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/metamail"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/Dual-Life/mime-base64/blob/master/Base64.xs#L12")
        ],
        LicenseText = ReadResource("metamail.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("metamail.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense FSFULLR = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/FSFULLR"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/FSF_Unlimited_License#License_Retention_Variant")
        ],
        LicenseText = ReadResource("FSFULLR.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("FSFULLR.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OSET_PL_2_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OSET-PL-2.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.osetfoundation.org/public-license"),
            new Uri("https://opensource.org/licenses/OPL-2.1")
        ],
        LicenseText = ReadResource("OSET-PL-2.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OSET-PL-2.1.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense PIXAR = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Pixar"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/PixarAnimationStudios/OpenSubdiv/raw/v3_5_0/LICENSE.txt"),
            new Uri("https://graphics.pixar.com/opensubdiv/docs/license.html"),
            new Uri("https://github.com/PixarAnimationStudios/OpenSubdiv/blob/v3_5_0/opensubdiv/version.cpp#L2-L22")
        ],
        LicenseText = ReadResource("Pixar.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Pixar.template.txt"),
        StandardLicenseHeader = ReadResource("Pixar.header.txt"),
        Comment = "This license is essentially Apache-2.0 with modifications to section 6.\n\n",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense WSUIPA = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Wsuipa"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/Wsuipa")
        ],
        LicenseText = ReadResource("Wsuipa.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Wsuipa.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense UNLICENSE_LIBTELNET = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Unlicense-libtelnet"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/seanmiddleditch/libtelnet/blob/develop/COPYING")
        ],
        LicenseText = ReadResource("Unlicense-libtelnet.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Unlicense-libtelnet.template.txt"),
        Comment = "This is license contains a small part of the Unlicense, but is much shorter.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SOUNDEX = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Soundex"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://metacpan.org/release/RJBS/Text-Soundex-3.05/source/Soundex.pm#L3-11")
        ],
        LicenseText = ReadResource("Soundex.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Soundex.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LIBSELINUX_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/libselinux-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/SELinuxProject/selinux/blob/master/libselinux/LICENSE")
        ],
        LicenseText = ReadResource("libselinux-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("libselinux-1.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CDDL_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CDDL-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/cddl1")
        ],
        LicenseText = ReadResource("CDDL-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CDDL-1.0.template.txt"),
        Comment = "This license was released: 24 January 2004.",
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OLDAP_2_2 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OLDAP-2.2"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.openldap.org/devel/gitweb.cgi?p=openldap.git;a=blob;f=LICENSE;hb=470b0c18ec67621c85881b2733057fecf4a1acc3")
        ],
        LicenseText = ReadResource("OLDAP-2.2.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OLDAP-2.2.template.txt"),
        Comment = "This license was released 1 March 2000.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense INTEL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Intel"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/Intel")
        ],
        LicenseText = ReadResource("Intel.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Intel.template.txt"),
        Comment = "This license has been deprecated. A note at the top of the OSI license page states, \"The Intel Open Source License for CDSA/CSSM Implementation (BSD License with Export Notice) (Intel has ceased to use or recommend this license)\"",
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense POLYFORM_NONCOMMERCIAL_1_0_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/PolyForm-Noncommercial-1.0.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://polyformproject.org/licenses/noncommercial/1.0.0")
        ],
        LicenseText = ReadResource("PolyForm-Noncommercial-1.0.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("PolyForm-Noncommercial-1.0.0.template.txt"),
        Comment = "This license was released on July 9, 2019.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense TTWL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/TTWL"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/TTWL"),
            new Uri("https://github.com/ap/Text-Tabs/blob/master/lib.modern/Text/Tabs.pm#L148")
        ],
        LicenseText = ReadResource("TTWL.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("TTWL.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense UNIXCRYPT = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/UnixCrypt"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://foss.heptapod.net/python-libs/passlib/-/blob/branch/stable/LICENSE#L70"),
            new Uri("https://opensource.apple.com/source/JBoss/JBoss-737/jboss-all/jetty/src/main/org/mortbay/util/UnixCrypt.java.auto.html"),
            new Uri("https://archive.eclipse.org/jetty/8.0.1.v20110908/xref/org/eclipse/jetty/http/security/UnixCrypt.html")
        ],
        LicenseText = ReadResource("UnixCrypt.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("UnixCrypt.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense HPND_DOC_SELL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/HPND-doc-sell"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://gitlab.freedesktop.org/xorg/lib/libxtst/-/blob/master/COPYING?ref_type=heads#L108-117"),
            new Uri("https://gitlab.freedesktop.org/xorg/lib/libxext/-/blob/master/COPYING?ref_type=heads#L153-162")
        ],
        LicenseText = ReadResource("HPND-doc-sell.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("HPND-doc-sell.template.txt"),
        Comment = "This is very similar to HPND-sell-variant but it is for documentation and alters the notice obligation.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense UMICH_MERIT = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/UMich-Merit"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/radcli/radcli/blob/master/COPYRIGHT#L64")
        ],
        LicenseText = ReadResource("UMich-Merit.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("UMich-Merit.template.txt"),
        Comment = "This license starts with an HPND-like grant, but has additional obligations (similar to HPND-Kevlin-Henney and HPND_Pbmplus) and a different disclaimer of warranties.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense NAUMEN = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Naumen"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/Naumen")
        ],
        LicenseText = ReadResource("Naumen.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Naumen.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CRYSTALSTACKER = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CrystalStacker"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing:CrystalStacker?rd=Licensing/CrystalStacker")
        ],
        LicenseText = ReadResource("CrystalStacker.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CrystalStacker.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LGPL_2_0_ONLY = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/LGPL-2.0-only"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/old-licenses/lgpl-2.0-standalone.html")
        ],
        LicenseText = ReadResource("LGPL-2.0-only.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("LGPL-2.0-only.template.txt"),
        StandardLicenseHeader = ReadResource("LGPL-2.0-only.header.txt"),
        Comment = "This license was released: June 1991. This license has been superseded by LGPL-2.1. This license identifier refers to the choice to use the code under LGPL-2.0-only, as distinguished from use of code under LGPL-2.0-or-later (i.e., LGPL-2.0 or some later version). The license notice (as seen in the Standard License Header field below) states which of these applies to the code in the file. The example in the exhibit to the license shows the license notice for the \"or later\" approach.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BSD_3_CLAUSE_LBNL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/BSD-3-Clause-LBNL"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/LBNLBSD")
        ],
        LicenseText = ReadResource("BSD-3-Clause-LBNL.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("BSD-3-Clause-LBNL.template.txt"),
        Comment = "This license is the same as BSD-3-Clause, but with an additional default contribution licensing clause",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense MPICH2 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/mpich2"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/MIT")
        ],
        LicenseText = ReadResource("mpich2.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("mpich2.template.txt"),
        Comment = "The MPICH2 project renamed itself to MPICH in 2012; the pre-existing license ID `mpich2` is retained here.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_NC_SA_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-NC-SA-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by-nc-sa/2.0/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-NC-SA-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-NC-SA-2.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GPL_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GPL-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/old-licenses/gpl-2.0-standalone.html"),
            new Uri("https://opensource.org/licenses/GPL-2.0")
        ],
        LicenseText = ReadResource("GPL-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GPL-2.0.template.txt"),
        StandardLicenseHeader = ReadResource("GPL-2.0.header.txt"),
        IsFsfLibre = true,
        IsOsiApproved = true,
        IsDeprecatedLicenseId = true,
        DeprecatedVersion = "3.0",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OLFL_1_3 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OLFL-1.3"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://openlogisticsfoundation.org/licenses/"),
            new Uri("https://opensource.org/license/olfl-1-3/")
        ],
        LicenseText = ReadResource("OLFL-1.3.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OLFL-1.3.template.txt"),
        Comment = "This license was released January 2023",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense IMATIX = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/iMatix"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://legacy.imatix.com/html/sfl/sfl4.htm#license")
        ],
        LicenseText = ReadResource("iMatix.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("iMatix.template.txt"),
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense APSL_1_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/APSL-1.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.opensource.apple.com/source/IOSerialFamily/IOSerialFamily-7/APPLE_LICENSE")
        ],
        LicenseText = ReadResource("APSL-1.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("APSL-1.1.template.txt"),
        Comment = "This license was released 19 April 1999.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense MINPACK = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Minpack"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.netlib.org/minpack/disclaimer"),
            new Uri("https://gitlab.com/libeigen/eigen/-/blob/master/COPYING.MINPACK")
        ],
        LicenseText = ReadResource("Minpack.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Minpack.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LEPTONICA = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Leptonica"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/Leptonica")
        ],
        LicenseText = ReadResource("Leptonica.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Leptonica.template.txt"),
        Comment = "This is an older license for Leptonica. Currently, it uses BSD-2-Clause (see http://www.leptonica.com/about-the-license.html)",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LGPL_2_0_OR_LATER = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/LGPL-2.0-or-later"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/old-licenses/lgpl-2.0-standalone.html")
        ],
        LicenseText = ReadResource("LGPL-2.0-or-later.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("LGPL-2.0-or-later.template.txt"),
        StandardLicenseHeader = ReadResource("LGPL-2.0-or-later.header.txt"),
        Comment = "This license was released: June 1991. This license has been superseded by LGPL-2.1. This license identifier refers to the choice to use code under LGPL-2.0-or-later (i.e., LGPL-2.0 or some later version), as distinguished from use of code under LGPL-2.0-only. The license notice (as seen in the Standard License Header field below) states which of these applies the code in the file. The example in the exhibit to the license shows the license notice for the \"or later\" approach.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BSD_3_CLAUSE_ATTRIBUTION = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/BSD-3-Clause-Attribution"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/BSD_with_Attribution")
        ],
        LicenseText = ReadResource("BSD-3-Clause-Attribution.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("BSD-3-Clause-Attribution.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense HPND_EXPORT_US_MODIFY = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/HPND-export-US-modify"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/krb5/krb5/blob/krb5-1.21.2-final/NOTICE#L1157-L1182"),
            new Uri("https://github.com/pythongssapi/k5test/blob/v0.10.3/K5TEST-LICENSE.txt")
        ],
        LicenseText = ReadResource("HPND-export-US-modify.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("HPND-export-US-modify.template.txt"),
        Comment = "This is very similar to HPND-export-US but adds a requirement related to modifications of the code.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_ND_3_0_DE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-ND-3.0-DE"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by-nd/3.0/de/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-ND-3.0-DE.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-ND-3.0-DE.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense ZPL_1_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/ZPL-1.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://old.zope.org/Resources/License/ZPL-1.1")
        ],
        LicenseText = ReadResource("ZPL-1.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("ZPL-1.1.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense VOSTROM = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/VOSTROM"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/VOSTROM")
        ],
        LicenseText = ReadResource("VOSTROM.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("VOSTROM.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense PYTHON_LDAP = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/python-ldap"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/python-ldap/python-ldap/blob/main/LICENCE")
        ],
        LicenseText = ReadResource("python-ldap.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("python-ldap.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense APACHE_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Apache-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.apache.org/licenses/LICENSE-1.0")
        ],
        LicenseText = ReadResource("Apache-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Apache-1.0.template.txt"),
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense IEC_CODE_COMPONENTS_EULA = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/IEC-Code-Components-EULA"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.iec.ch/webstore/custserv/pdf/CC-EULA.pdf"),
            new Uri("https://www.iec.ch/CCv1"),
            new Uri("https://www.iec.ch/copyright")
        ],
        LicenseText = ReadResource("IEC-Code-Components-EULA.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("IEC-Code-Components-EULA.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense NUNIT = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Nunit"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/Nunit")
        ],
        LicenseText = ReadResource("Nunit.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Nunit.template.txt"),
        IsFsfLibre = true,
        IsOsiApproved = false,
        IsDeprecatedLicenseId = true,
        DeprecatedVersion = "3.0",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense EUPL_1_2 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/EUPL-1.2"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://joinup.ec.europa.eu/page/eupl-text-11-12"),
            new Uri("https://joinup.ec.europa.eu/sites/default/files/custom-page/attachment/eupl_v1.2_en.pdf"),
            new Uri("https://joinup.ec.europa.eu/sites/default/files/custom-page/attachment/2020-03/EUPL-1.2%20EN.txt"),
            new Uri("https://joinup.ec.europa.eu/sites/default/files/inline-files/EUPL%20v1_2%20EN(1).txt"),
            new Uri("http://eur-lex.europa.eu/legal-content/EN/TXT/HTML/?uri=CELEX:32017D0863"),
            new Uri("https://opensource.org/licenses/EUPL-1.2")
        ],
        LicenseText = ReadResource("EUPL-1.2.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("EUPL-1.2.template.txt"),
        Comment = "This license was released: 19 May 2016. This license is available in the 22 official languages of the EU. The English version is included here.",
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense _0BSD = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/0BSD"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://landley.net/toybox/license.html"),
            new Uri("https://opensource.org/licenses/0BSD")
        ],
        LicenseText = ReadResource("0BSD.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("0BSD.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BRIAN_GLADMAN_2_CLAUSE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Brian-Gladman-2-Clause"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/krb5/krb5/blob/krb5-1.21.2-final/NOTICE#L140-L156"),
            new Uri("https://web.mit.edu/kerberos/krb5-1.21/doc/mitK5license.html")
        ],
        LicenseText = ReadResource("Brian-Gladman-2-Clause.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Brian-Gladman-2-Clause.template.txt"),
        Comment = "This is similar to Brian-Gladman-3-Clause but sort omits the third clause, adds \"without the payment of fees or royalties\", and re-words the lead-in and first two clauses.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OGTSL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OGTSL"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.opengroup.org/testing/downloads/The_Open_Group_TSL.txt"),
            new Uri("https://opensource.org/licenses/OGTSL")
        ],
        LicenseText = ReadResource("OGTSL.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OGTSL.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CUA_OPL_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CUA-OPL-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/CUA-OPL-1.0")
        ],
        LicenseText = ReadResource("CUA-OPL-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CUA-OPL-1.0.template.txt"),
        StandardLicenseHeader = ReadResource("CUA-OPL-1.0.header.txt"),
        Comment = "The CUA Office Project has ceased to use or recommend this license. This license is essentially a rebranded version of MPL-1.1, but was included on the SPDX License List due to its OSI-approved status.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LATEX2E_TRANSLATED_NOTICE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Latex2e-translated-notice"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://git.savannah.gnu.org/cgit/indent.git/tree/doc/indent.texi?id=a74c6b4ee49397cf330b333da1042bffa60ed14f#n74")
        ],
        LicenseText = ReadResource("Latex2e-translated-notice.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Latex2e-translated-notice.template.txt"),
        Comment = "The last section differs from Latex2e license.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense FURUSETH = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Furuseth"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://git.openldap.org/openldap/openldap/-/blob/master/COPYRIGHT?ref_type=heads#L39-51")
        ],
        LicenseText = ReadResource("Furuseth.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Furuseth.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SSH_SHORT = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/SSH-short"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/openssh/openssh-portable/blob/1b11ea7c58cd5c59838b5fa574cd456d6047b2d4/pathnames.h"),
            new Uri("http://web.mit.edu/kolya/.f/root/athena.mit.edu/sipb.mit.edu/project/openssh/OldFiles/src/openssh-2.9.9p2/ssh-add.1"),
            new Uri("https://joinup.ec.europa.eu/svn/lesoll/trunk/italc/lib/src/dsa_key.cpp")
        ],
        LicenseText = ReadResource("SSH-short.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("SSH-short.template.txt"),
        Comment = "This is short version of SSH-OpenSSH that appears in some files associated with the original SSH implementation.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense TGPPL_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/TGPPL-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/TGPPL"),
            new Uri("https://tahoe-lafs.org/trac/tahoe-lafs/browser/trunk/COPYING.TGPPL.rst")
        ],
        LicenseText = ReadResource("TGPPL-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("TGPPL-1.0.template.txt"),
        StandardLicenseHeader = ReadResource("TGPPL-1.0.header.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense AGPL_3_0_OR_LATER = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/AGPL-3.0-or-later"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/agpl.txt"),
            new Uri("https://opensource.org/licenses/AGPL-3.0")
        ],
        LicenseText = ReadResource("AGPL-3.0-or-later.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("AGPL-3.0-or-later.template.txt"),
        StandardLicenseHeader = ReadResource("AGPL-3.0-or-later.header.txt"),
        Comment = "This version was released: 19 November 2007. This license identifier refers to the choice to use code under AGPL-3.0-or-later (i.e., AGPL-3.0 or some later version), as distinguished from use of code under AGPL-3.0-only. The license notice (as seen in the Standard License Header field below) states which of these applies the code in the file. The example in the exhibit to the license shows the license notice for the \"or later\" approach.",
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_NC_2_5 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-NC-2.5"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by-nc/2.5/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-NC-2.5.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-NC-2.5.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LGPL_3_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/LGPL-3.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/lgpl-3.0-standalone.html"),
            new Uri("https://www.gnu.org/licenses/lgpl+gpl-3.0.txt"),
            new Uri("https://opensource.org/licenses/LGPL-3.0")
        ],
        LicenseText = ReadResource("LGPL-3.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("LGPL-3.0.template.txt"),
        Comment = "The identifier \"LGPL-3.0\" has been deprecated; LGPL-3.0-only is the preferred identifier to indicate only version 3.0 of the LGPL.",
        IsFsfLibre = true,
        IsOsiApproved = true,
        IsDeprecatedLicenseId = true,
        DeprecatedVersion = "3.0",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense NIST_SOFTWARE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/NIST-Software"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/open-quantum-safe/liboqs/blob/40b01fdbb270f8614fde30e65d30e9da18c02393/src/common/rand/rand_nist.c#L1-L15")
        ],
        LicenseText = ReadResource("NIST-Software.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("NIST-Software.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BSD_2_CLAUSE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/BSD-2-Clause"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/BSD-2-Clause")
        ],
        LicenseText = ReadResource("BSD-2-Clause.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("BSD-2-Clause.template.txt"),
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BSD_3_CLAUSE_NO_MILITARY_LICENSE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/BSD-3-Clause-No-Military-License"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://gitlab.syncad.com/hive/dhive/-/blob/master/LICENSE"),
            new Uri("https://github.com/greymass/swift-eosio/blob/master/LICENSE")
        ],
        LicenseText = ReadResource("BSD-3-Clause-No-Military-License.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("BSD-3-Clause-No-Military-License.template.txt"),
        Comment = "This is the same as BSD-3-Clause-No-Nuclear-License-2014, except the acknowledgement in the last paragraph is that the software is not designed, licensed or intended for use in a military facility, instead of a nuclear facility.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense NLPL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/NLPL"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/NLPL")
        ],
        LicenseText = ReadResource("NLPL.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("NLPL.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense POLYFORM_SMALL_BUSINESS_1_0_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/PolyForm-Small-Business-1.0.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://polyformproject.org/licenses/small-business/1.0.0")
        ],
        LicenseText = ReadResource("PolyForm-Small-Business-1.0.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("PolyForm-Small-Business-1.0.0.template.txt"),
        Comment = "This license was released on July 9, 2019.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense KNUTH_CTAN = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Knuth-CTAN"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://ctan.org/license/knuth")
        ],
        LicenseText = ReadResource("Knuth-CTAN.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Knuth-CTAN.template.txt"),
        Comment = "This license is very similar to Wsuipa.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OLDAP_2_0_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OLDAP-2.0.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.openldap.org/devel/gitweb.cgi?p=openldap.git;a=blob;f=LICENSE;hb=b6d68acd14e51ca3aab4428bf26522aa74873f0e")
        ],
        LicenseText = ReadResource("OLDAP-2.0.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OLDAP-2.0.1.template.txt"),
        Comment = "This license was released 21 December 1999. This license is the same as 2.0 with the word \"registered\" removed from in front of \"trademark.\"",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense AGPL_3_0_ONLY = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/AGPL-3.0-only"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/agpl.txt"),
            new Uri("https://opensource.org/licenses/AGPL-3.0")
        ],
        LicenseText = ReadResource("AGPL-3.0-only.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("AGPL-3.0-only.template.txt"),
        StandardLicenseHeader = ReadResource("AGPL-3.0-only.header.txt"),
        Comment = "This version was released: 19 November 2007. This license identifier refers to the choice to use the code under AGPL-3.0-only, as distinguished from use of code under AGPL-3.0-or-later (i.e., AGPL-3.0 or some later version). The license notice (as seen in the Standard License Header field below) states which of these applies to the code in the file. The example in the exhibit to the license shows the license notice for the \"or later\" approach.",
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GAME_PROGRAMMING_GEMS = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Game-Programming-Gems"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/OGRECave/ogre/blob/master/OgreMain/include/OgreSingleton.h#L28C3-L35C46")
        ],
        LicenseText = ReadResource("Game-Programming-Gems.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Game-Programming-Gems.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BSD_3_CLAUSE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/BSD-3-Clause"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/BSD-3-Clause"),
            new Uri("https://www.eclipse.org/org/documents/edl-v10.php")
        ],
        LicenseText = ReadResource("BSD-3-Clause.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("BSD-3-Clause.template.txt"),
        Comment = "Note for matching purposes, this license contains a number of equivalent variations, particularly in the third clause. See the XML file for more details. Also note that the Eclipse Distribution License - v 1.0 (EDL 1.0) is a match to BSD-3-Clause, even though it uses a different name.",
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense NAIST_2003 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/NAIST-2003"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://enterprise.dejacode.com/licenses/public/naist-2003/#license-text"),
            new Uri("https://github.com/nodejs/node/blob/4a19cc8947b1bba2b2d27816ec3d0edf9b28e503/LICENSE#L343")
        ],
        LicenseText = ReadResource("NAIST-2003.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("NAIST-2003.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CERN_OHL_1_2 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CERN-OHL-1.2"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.ohwr.org/project/licenses/wikis/cern-ohl-v1.2")
        ],
        LicenseText = ReadResource("CERN-OHL-1.2.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CERN-OHL-1.2.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_NC_SA_2_0_FR = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-NC-SA-2.0-FR"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by-nc-sa/2.0/fr/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-NC-SA-2.0-FR.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-NC-SA-2.0-FR.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense ARTISTIC_DIST = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Artistic-dist"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/pexip/os-perl/blob/833cf4c86cc465ccfc627ff16db67e783156a248/debian/copyright#L2720-L2845")
        ],
        LicenseText = ReadResource("Artistic-dist.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Artistic-dist.template.txt"),
        Comment = "This license is very similar to Artistic-1.0-Perl, but uses a different clause 7 and has changes in clause 5.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense NBPL_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/NBPL-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.openldap.org/devel/gitweb.cgi?p=openldap.git;a=blob;f=LICENSE;hb=37b4b3f6cc4bf34e1d3dec61e69914b9819d8894")
        ],
        LicenseText = ReadResource("NBPL-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("NBPL-1.0.template.txt"),
        Comment = "This license was released 22 August 1998. This license was issued twice, but only with formatting differences.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CALDERA = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Caldera"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.lemis.com/grog/UNIX/ancient-source-all.pdf")
        ],
        LicenseText = ReadResource("Caldera.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Caldera.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense MIT_OPEN_GROUP = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/MIT-open-group"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://gitlab.freedesktop.org/xorg/app/iceauth/-/blob/master/COPYING"),
            new Uri("https://gitlab.freedesktop.org/xorg/app/xsetroot/-/blob/master/COPYING"),
            new Uri("https://gitlab.freedesktop.org/xorg/app/xauth/-/blob/master/COPYING")
        ],
        LicenseText = ReadResource("MIT-open-group.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("MIT-open-group.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BITSTREAM_CHARTER = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Bitstream-Charter"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/Charter#License_Text"),
            new Uri("https://raw.githubusercontent.com/blackhole89/notekit/master/data/fonts/Charter%20license.txt")
        ],
        LicenseText = ReadResource("Bitstream-Charter.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Bitstream-Charter.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CERN_OHL_S_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CERN-OHL-S-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.ohwr.org/project/cernohl/wikis/Documents/CERN-OHL-version-2")
        ],
        LicenseText = ReadResource("CERN-OHL-S-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CERN-OHL-S-2.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense W3C_20150513 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/W3C-20150513"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.w3.org/Consortium/Legal/2015/copyright-software-and-document"),
            new Uri("https://www.w3.org/copyright/software-license-2015/"),
            new Uri("https://www.w3.org/copyright/software-license-2023/")
        ],
        LicenseText = ReadResource("W3C-20150513.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("W3C-20150513.template.txt"),
        StandardLicenseHeader = ReadResource("W3C-20150513.header.txt"),
        Comment = "This license takes effect 13 May, 2015. The changes from the previous version make clear that the license is applicable to both software and text, by changing the name and substituting \"work\" for instances of \"software and its documentation.\" It moves \"notice of changes or modifications to the files\" to the copyright notice, to make clear that the license is compatible with other liberal licenses. In 2023, W3C made minor modifications to this license as of Jan 1, 2023 (see URL above). However, those changes did not give rise to a new license under the SPDX Matching Guidelines, thus the same id can be used.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense EPL_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/EPL-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.eclipse.org/legal/epl-v10.html"),
            new Uri("https://opensource.org/licenses/EPL-1.0")
        ],
        LicenseText = ReadResource("EPL-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("EPL-1.0.template.txt"),
        Comment = "EPL replaced the CPL on 28 June 2005.",
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense QPL_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/QPL-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://doc.qt.nokia.com/3.3/license.html"),
            new Uri("https://opensource.org/licenses/QPL-1.0"),
            new Uri("https://doc.qt.io/archives/3.3/license.html")
        ],
        LicenseText = ReadResource("QPL-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("QPL-1.0.template.txt"),
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense FSFAP_NO_WARRANTY_DISCLAIMER = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/FSFAP-no-warranty-disclaimer"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://git.savannah.gnu.org/cgit/wget.git/tree/util/trunc.c?h=v1.21.3&id=40747a11e44ced5a8ac628a41f879ced3e2ebce9#n6")
        ],
        LicenseText = ReadResource("FSFAP-no-warranty-disclaimer.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("FSFAP-no-warranty-disclaimer.template.txt"),
        Comment = "This license is identical to FSFAP except it omits the no-warranty sentence at the end.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_NC_ND_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-NC-ND-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by-nd-nc/1.0/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-NC-ND-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-NC-ND-1.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense ASWF_DIGITAL_ASSETS_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/ASWF-Digital-Assets-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/AcademySoftwareFoundation/foundation/blob/main/digital_assets/aswf_digital_assets_license_v1.0.txt")
        ],
        LicenseText = ReadResource("ASWF-Digital-Assets-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("ASWF-Digital-Assets-1.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BCRYPT_SOLAR_DESIGNER = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/bcrypt-Solar-Designer"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/bcrypt-ruby/bcrypt-ruby/blob/master/ext/mri/crypt_blowfish.c")
        ],
        LicenseText = ReadResource("bcrypt-Solar-Designer.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("bcrypt-Solar-Designer.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense YPL_1_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/YPL-1.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.zimbra.com/license/yahoo_public_license_1.1.html")
        ],
        LicenseText = ReadResource("YPL-1.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("YPL-1.1.template.txt"),
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense FRAMEWORX_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Frameworx-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/Frameworx-1.0")
        ],
        LicenseText = ReadResource("Frameworx-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Frameworx-1.0.template.txt"),
        Comment = "The url included in the license does not work. (15/10/10)",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BITTORRENT_1_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/BitTorrent-1.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://directory.fsf.org/wiki/License:BitTorrentOSL1.1")
        ],
        LicenseText = ReadResource("BitTorrent-1.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("BitTorrent-1.1.template.txt"),
        StandardLicenseHeader = ReadResource("BitTorrent-1.1.header.txt"),
        Comment = "The upstream Exhibit A suggests the wrong version number.",
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CURL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/curl"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/bagder/curl/blob/master/COPYING")
        ],
        LicenseText = ReadResource("curl.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("curl.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GFDL_1_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GFDL-1.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/old-licenses/fdl-1.1.txt")
        ],
        LicenseText = ReadResource("GFDL-1.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GFDL-1.1.template.txt"),
        StandardLicenseHeader = ReadResource("GFDL-1.1.header.txt"),
        IsFsfLibre = true,
        IsOsiApproved = false,
        IsDeprecatedLicenseId = true,
        DeprecatedVersion = "3.0",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense MPL_1_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/MPL-1.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.mozilla.org/MPL/MPL-1.1.html"),
            new Uri("https://opensource.org/licenses/MPL-1.1")
        ],
        LicenseText = ReadResource("MPL-1.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("MPL-1.1.template.txt"),
        StandardLicenseHeader = ReadResource("MPL-1.1.header.txt"),
        Comment = "This license has been superseded by v2.0",
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LZMA_SDK_9_11_TO_9_20 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/LZMA-SDK-9.11-to-9.20"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.7-zip.org/sdk.html"),
            new Uri("https://sourceforge.net/projects/sevenzip/files/LZMA%20SDK/")
        ],
        LicenseText = ReadResource("LZMA-SDK-9.11-to-9.20.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("LZMA-SDK-9.11-to-9.20.template.txt"),
        Comment = "The license text currently displayed on the 7-zip SDK website is not the same as any of the lzma.txt file in the root folders of the .tar.bz SDK distributions (versions 922 and below) that are hosted on SourceForge, nor is it the same as the .7z distributions (versions 935 and above) which shifted the license text to DOC\\lzma-sdk.txt. This license applies to versions between 9.11 and 9.20 (inclusive).",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense WTFPL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/WTFPL"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.wtfpl.net/about/"),
            new Uri("http://sam.zoy.org/wtfpl/COPYING")
        ],
        LicenseText = ReadResource("WTFPL.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("WTFPL.template.txt"),
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense FTL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/FTL"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://freetype.fis.uniroma2.it/FTL.TXT"),
            new Uri("http://git.savannah.gnu.org/cgit/freetype/freetype2.git/tree/docs/FTL.TXT"),
            new Uri("http://gitlab.freedesktop.org/freetype/freetype/-/raw/master/docs/FTL.TXT")
        ],
        LicenseText = ReadResource("FTL.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("FTL.template.txt"),
        Comment = "This license was released 27 Jan 2006",
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_NC_ND_3_0_IGO = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-NC-ND-3.0-IGO"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by-nc-nd/3.0/igo/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-NC-ND-3.0-IGO.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-NC-ND-3.0-IGO.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CRONYX = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Cronyx"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://gitlab.freedesktop.org/xorg/font/alias/-/blob/master/COPYING"),
            new Uri("https://gitlab.freedesktop.org/xorg/font/cronyx-cyrillic/-/blob/master/COPYING"),
            new Uri("https://gitlab.freedesktop.org/xorg/font/misc-cyrillic/-/blob/master/COPYING"),
            new Uri("https://gitlab.freedesktop.org/xorg/font/screen-cyrillic/-/blob/master/COPYING")
        ],
        LicenseText = ReadResource("Cronyx.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Cronyx.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense HPND_INTEL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/HPND-Intel"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://sourceware.org/git/?p=newlib-cygwin.git;a=blob;f=newlib/libc/machine/i960/memcpy.S;hb=HEAD")
        ],
        LicenseText = ReadResource("HPND-Intel.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("HPND-Intel.template.txt"),
        Comment = "Similar to HPND with some changes, in particular with a \"prominent mark\" requirement for modifications and additional disclaimers.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense FREEBSD_DOC = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/FreeBSD-DOC"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.freebsd.org/copyright/freebsd-doc-license/")
        ],
        LicenseText = ReadResource("FreeBSD-DOC.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("FreeBSD-DOC.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense ABSTYLES = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Abstyles"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/Abstyles")
        ],
        LicenseText = ReadResource("Abstyles.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Abstyles.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense HPND_DOC = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/HPND-doc"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://gitlab.freedesktop.org/xorg/lib/libxext/-/blob/master/COPYING?ref_type=heads#L185-197"),
            new Uri("https://gitlab.freedesktop.org/xorg/lib/libxtst/-/blob/master/COPYING?ref_type=heads#L70-77")
        ],
        LicenseText = ReadResource("HPND-doc.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("HPND-doc.template.txt"),
        Comment = "This is very similar to HPND but is for documentation and alters the notice obligation.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LIBPNG_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/libpng-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.libpng.org/pub/png/src/libpng-LICENSE.txt")
        ],
        LicenseText = ReadResource("libpng-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("libpng-2.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense HPND_NETREK = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/HPND-Netrek"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
        ],
        LicenseText = ReadResource("HPND-Netrek.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("HPND-Netrek.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense XNET = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Xnet"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/Xnet")
        ],
        LicenseText = ReadResource("Xnet.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Xnet.template.txt"),
        Comment = "This license is the same as MIT, but with a choice of law clause. This License has been voluntarily deprecated by its author.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OGL_CANADA_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OGL-Canada-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://open.canada.ca/en/open-government-licence-canada")
        ],
        LicenseText = ReadResource("OGL-Canada-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OGL-Canada-2.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense MACKERRAS_3_CLAUSE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Mackerras-3-Clause"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/ppp-project/ppp/blob/master/pppd/chap_ms.c#L6-L28")
        ],
        LicenseText = ReadResource("Mackerras-3-Clause.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Mackerras-3-Clause.template.txt"),
        Comment = "This is similar to Mackerras-3-Clause-acknowledgment but has the binary clause and removes the acknowledgement clause. The grants are similar to BSD-3-Clause, but with a different disclaimer.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BSD_ADVERTISING_ACKNOWLEDGEMENT = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/BSD-Advertising-Acknowledgement"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/python-excel/xlrd/blob/master/LICENSE#L33")
        ],
        LicenseText = ReadResource("BSD-Advertising-Acknowledgement.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("BSD-Advertising-Acknowledgement.template.txt"),
        Comment = "This appears to be similar BSD-4-Clause, but replaces the \"no endorsement\" 4th clause with an attribution clause.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense EUDATAGRID = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/EUDatagrid"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://eu-datagrid.web.cern.ch/eu-datagrid/license.html"),
            new Uri("https://opensource.org/licenses/EUDatagrid")
        ],
        LicenseText = ReadResource("EUDatagrid.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("EUDatagrid.template.txt"),
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense AML = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/AML"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/Apple_MIT_License")
        ],
        LicenseText = ReadResource("AML.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("AML.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SUN_PPP = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Sun-PPP"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/ppp-project/ppp/blob/master/pppd/eap.c#L7-L16")
        ],
        LicenseText = ReadResource("Sun-PPP.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Sun-PPP.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CERN_OHL_1_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CERN-OHL-1.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.ohwr.org/project/licenses/wikis/cern-ohl-v1.1")
        ],
        LicenseText = ReadResource("CERN-OHL-1.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CERN-OHL-1.1.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_NC_ND_4_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-NC-ND-4.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by-nc-nd/4.0/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-NC-ND-4.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-NC-ND-4.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense XLOCK = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/xlock"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fossies.org/linux/tiff/contrib/ras/ras2tif.c")
        ],
        LicenseText = ReadResource("xlock.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("xlock.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SNPRINTF = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/snprintf"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/openssh/openssh-portable/blob/master/openbsd-compat/bsd-snprintf.c#L2")
        ],
        LicenseText = ReadResource("snprintf.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("snprintf.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OFL_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OFL-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://scripts.sil.org/cms/scripts/page.php?item_id=OFL10_web")
        ],
        LicenseText = ReadResource("OFL-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OFL-1.0.template.txt"),
        Comment = "This license has been superseded. This license was released in November 2005. The identifier OFL-1.0 can be used to indicate that version 1.0 of the SIL Open Font License applies, without asserting whether or not a Reserved Font Name is used. See OFL-1.0-RFN and OFL-1.0-no-RFN for alternative identifiers that can be used to express explicitly that a Reserved Font Name is used or is not used, respectively.",
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense FSFAP = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/FSFAP"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/prep/maintain/html_node/License-Notices-for-Other-Files.html")
        ],
        LicenseText = ReadResource("FSFAP.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("FSFAP.template.txt"),
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense W3C_19980720 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/W3C-19980720"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.w3.org/Consortium/Legal/copyright-software-19980720.html")
        ],
        LicenseText = ReadResource("W3C-19980720.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("W3C-19980720.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_3_0_AU = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-3.0-AU"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by/3.0/au/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-3.0-AU.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-3.0-AU.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_SA_2_5 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-SA-2.5"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by-sa/2.5/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-SA-2.5.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-SA-2.5.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GFDL_1_1_NO_INVARIANTS_OR_LATER = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GFDL-1.1-no-invariants-or-later"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/old-licenses/fdl-1.1.txt")
        ],
        LicenseText = ReadResource("GFDL-1.1-no-invariants-or-later.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GFDL-1.1-no-invariants-or-later.template.txt"),
        StandardLicenseHeader = ReadResource("GFDL-1.1-no-invariants-or-later.header.txt"),
        Comment = "This license was released March 2000. The identifier GFDL-1.1-or-later-no-invariants should only be used when there are no Invariant Sections, Front-Cover Texts or Back-Cover Texts. See GFDL-1.1-or-later and GFDL-1.1-or-later-invariants for alternatives.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense MIROS = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/MirOS"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/MirOS")
        ],
        LicenseText = ReadResource("MirOS.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("MirOS.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OFL_1_0_NO_RFN = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OFL-1.0-no-RFN"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://scripts.sil.org/cms/scripts/page.php?item_id=OFL10_web")
        ],
        LicenseText = ReadResource("OFL-1.0-no-RFN.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OFL-1.0-no-RFN.template.txt"),
        Comment = "This license has been superseded. This license was released in November 2005. The identifier OFL-1.0-no-RFN should only be used when there is no Reserved Font Name. See OFL-1.0 and OFL-1.0-RFN for alternatives.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense HPND_SELL_VARIANT_MIT_DISCLAIMER_REV = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/HPND-sell-variant-MIT-disclaimer-rev"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/sigmavirus24/x11-ssh-askpass/blob/master/dynlist.c")
        ],
        LicenseText = ReadResource("HPND-sell-variant-MIT-disclaimer-rev.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("HPND-sell-variant-MIT-disclaimer-rev.template.txt"),
        Comment = "This license matches the text of HPND-sell-variant-MIT-disclaimer, but reverses the order of the clauses.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense FERGUSON_TWOFISH = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Ferguson-Twofish"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/wernerd/ZRTPCPP/blob/6b3cd8e6783642292bad0c21e3e5e5ce45ff3e03/cryptcommon/twofish.c#L113C3-L127")
        ],
        LicenseText = ReadResource("Ferguson-Twofish.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Ferguson-Twofish.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GPL_2_0_WITH_BISON_EXCEPTION = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GPL-2.0-with-bison-exception"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://git.savannah.gnu.org/cgit/bison.git/tree/data/yacc.c?id=193d7c7054ba7197b0789e14965b739162319b5e#n141")
        ],
        LicenseText = ReadResource("GPL-2.0-with-bison-exception.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GPL-2.0-with-bison-exception.template.txt"),
        Comment = "DEPRECATED: Use license expression including main license, \"WITH\" operator, and identifier: Bison-exception-2.2",
        IsDeprecatedLicenseId = true,
        DeprecatedVersion = "2.0rc2",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GFDL_1_1_NO_INVARIANTS_ONLY = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GFDL-1.1-no-invariants-only"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/old-licenses/fdl-1.1.txt")
        ],
        LicenseText = ReadResource("GFDL-1.1-no-invariants-only.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GFDL-1.1-no-invariants-only.template.txt"),
        StandardLicenseHeader = ReadResource("GFDL-1.1-no-invariants-only.header.txt"),
        Comment = "This license was released March 2000. The identifier GFDL-1.1-only-no-invariants should only be used when there are no Invariant Sections, Front-Cover Texts or Back-Cover Texts. See GFDL-1.1-only and GFDL-1.1-only-invariants for alternatives.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense ECL_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/ECL-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/ECL-2.0")
        ],
        LicenseText = ReadResource("ECL-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("ECL-2.0.template.txt"),
        StandardLicenseHeader = ReadResource("ECL-2.0.header.txt"),
        Comment = "The Educational Community License version 2.0 (\"ECL\") consists of the Apache 2.0 license, modified to change the scope of the patent grant in section 3 to be specific to the needs of the education communities using this license. The url included in the boilerplate notice does not work. (15/10/10)",
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense MOTOSOTO = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Motosoto"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/Motosoto")
        ],
        LicenseText = ReadResource("Motosoto.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Motosoto.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense DOCBOOK_STYLESHEET = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/DocBook-Stylesheet"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.docbook.org/xml/5.0/docbook-5.0.zip")
        ],
        LicenseText = ReadResource("DocBook-Stylesheet.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("DocBook-Stylesheet.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_NC_3_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-NC-3.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by-nc/3.0/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-NC-3.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-NC-3.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OPL_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OPL-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://old.koalateam.com/jackaroo/OPL_1_0.TXT"),
            new Uri("https://fedoraproject.org/wiki/Licensing/Open_Public_License")
        ],
        LicenseText = ReadResource("OPL-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OPL-1.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LINUX_MAN_PAGES_COPYLEFT = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Linux-man-pages-copyleft"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.kernel.org/doc/man-pages/licenses.html")
        ],
        LicenseText = ReadResource("Linux-man-pages-copyleft.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Linux-man-pages-copyleft.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SHL_0_51 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/SHL-0.51"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://solderpad.org/licenses/SHL-0.51/")
        ],
        LicenseText = ReadResource("SHL-0.51.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("SHL-0.51.template.txt"),
        StandardLicenseHeader = ReadResource("SHL-0.51.header.txt"),
        Comment = "This license was released in March of 2019.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_NC_ND_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-NC-ND-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by-nc-nd/2.0/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-NC-ND-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-NC-ND-2.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SENDMAIL_OPEN_SOURCE_1_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Sendmail-Open-Source-1.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/trusteddomainproject/OpenDMARC/blob/master/LICENSE.Sendmail")
        ],
        LicenseText = ReadResource("Sendmail-Open-Source-1.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Sendmail-Open-Source-1.1.template.txt"),
        Comment = "Note that this license is distinct and not a different version from Sendmail or Sendmail-8.23",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_NC_3_0_DE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-NC-3.0-DE"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by-nc/3.0/de/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-NC-3.0-DE.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-NC-3.0-DE.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense NPL_1_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/NPL-1.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.mozilla.org/MPL/NPL/1.1/")
        ],
        LicenseText = ReadResource("NPL-1.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("NPL-1.1.template.txt"),
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense RADVD = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/radvd"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/radvd-project/radvd/blob/master/COPYRIGHT")
        ],
        LicenseText = ReadResource("radvd.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("radvd.template.txt"),
        Comment = "This license is almost a match to Inner-Net-2.0, but it includes clause 4 which Inner-Net-2.0 omits.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BSD_2_CLAUSE_PATENT = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/BSD-2-Clause-Patent"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/BSDplusPatent")
        ],
        LicenseText = ReadResource("BSD-2-Clause-Patent.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("BSD-2-Clause-Patent.template.txt"),
        Comment = "Note: This license is designed to provide: a) a simple permissive license; b) that is compatible with the GNU General Public License (GPL), version 2; and c) which also has an express patent grant included.\n\n",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense NTP_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/NTP-0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/tytso/e2fsprogs/blob/master/lib/et/et_name.c")
        ],
        LicenseText = ReadResource("NTP-0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("NTP-0.template.txt"),
        Comment = "This license is similar to NTP, but it omits the language regarding reproduction of copyright and permission notices. It also omits the phrase \"with or without fee\".",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense ARTISTIC_1_0_CL8 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Artistic-1.0-cl8"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/Artistic-1.0")
        ],
        LicenseText = ReadResource("Artistic-1.0-cl8.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Artistic-1.0-cl8.template.txt"),
        Comment = "This license was superseded by v2.0. This is Artistic License 1.0 as found on OSI site, including clause 8.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BSD_2_CLAUSE_FREEBSD = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/BSD-2-Clause-FreeBSD"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.freebsd.org/copyright/freebsd-license.html")
        ],
        LicenseText = ReadResource("BSD-2-Clause-FreeBSD.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("BSD-2-Clause-FreeBSD.template.txt"),
        Comment = "This license was deprecated because BSD-2-Clause-Views has been added, as a more generalized version; and because FreeBSD project community members have indicated that the final sentence is not part of that project's code license.",
        IsFsfLibre = true,
        IsOsiApproved = false,
        IsDeprecatedLicenseId = true,
        DeprecatedVersion = "3.10",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CAL_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CAL-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://cryptographicautonomylicense.com/license-text.html"),
            new Uri("https://opensource.org/licenses/CAL-1.0")
        ],
        LicenseText = ReadResource("CAL-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CAL-1.0.template.txt"),
        Comment = "The first draft of this license was released February 2019, and the fourth revision was approved by the OSI February 2020.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BSD_PROTECTION = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/BSD-Protection"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/BSD_Protection_License")
        ],
        LicenseText = ReadResource("BSD-Protection.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("BSD-Protection.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense HPND = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/HPND"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/HPND"),
            new Uri("http://lists.opensource.org/pipermail/license-discuss_lists.opensource.org/2002-November/006304.html")
        ],
        LicenseText = ReadResource("HPND.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("HPND.template.txt"),
        Comment = "This license has been voluntarily deprecated by its author. Original license submission in 2002 was intended to provide a template distilled from permission notices used in many packages. As per the original notes, \"It may be possible to construct a grammatically incorrect license from this template, or one that lacks a disclaimer, or one that includes a double-disclaimer. That is acceptable, as long as it remains impossible to construct a non-OSD-compliant license that matches the pattern.\"",
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BOEHM_GC_WITHOUT_FEE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Boehm-GC-without-fee"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/MariaDB/server/blob/11.6/libmysqld/lib_sql.cc")
        ],
        LicenseText = ReadResource("Boehm-GC-without-fee.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Boehm-GC-without-fee.template.txt"),
        Comment = "This license is similar to Boehm-GC with slightly different wording and adds \"without fee\".",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense TCP_WRAPPERS = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/TCP-wrappers"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://rc.quest.com/topics/openssh/license.php#tcpwrappers")
        ],
        LicenseText = ReadResource("TCP-wrappers.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("TCP-wrappers.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense TORQUE_1_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/TORQUE-1.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/TORQUEv1.1")
        ],
        LicenseText = ReadResource("TORQUE-1.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("TORQUE-1.1.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OSL_3_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OSL-3.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://web.archive.org/web/20120101081418/http://rosenlaw.com:80/OSL3.0.htm"),
            new Uri("https://opensource.org/licenses/OSL-3.0")
        ],
        LicenseText = ReadResource("OSL-3.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OSL-3.0.template.txt"),
        StandardLicenseHeader = ReadResource("OSL-3.0.header.txt"),
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense UNICODE_3_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Unicode-3.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.unicode.org/license.txt")
        ],
        LicenseText = ReadResource("Unicode-3.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Unicode-3.0.template.txt"),
        Comment = "Note, this url has been used for prior versions of this license as well.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense NPL_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/NPL-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.mozilla.org/MPL/NPL/1.0/")
        ],
        LicenseText = ReadResource("NPL-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("NPL-1.0.template.txt"),
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SYMLINKS = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Symlinks"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.mail-archive.com/debian-bugs-rc@lists.debian.org/msg11494.html")
        ],
        LicenseText = ReadResource("Symlinks.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Symlinks.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_SA_2_1_JP = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-SA-2.1-JP"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by-sa/2.1/jp/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-SA-2.1-JP.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-SA-2.1-JP.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense MIT_MODERN_VARIANT = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/MIT-Modern-Variant"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing:MIT#Modern_Variants"),
            new Uri("https://ptolemy.berkeley.edu/copyright.htm"),
            new Uri("https://pirlwww.lpl.arizona.edu/resources/guide/software/PerlTk/Tixlic.html")
        ],
        LicenseText = ReadResource("MIT-Modern-Variant.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("MIT-Modern-Variant.template.txt"),
        Comment = "This license is labeled as \"Modern Variant\" based on its corresponding listing on the Fedora licensing wiki page.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GFDL_1_3_INVARIANTS_OR_LATER = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GFDL-1.3-invariants-or-later"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/fdl-1.3.txt")
        ],
        LicenseText = ReadResource("GFDL-1.3-invariants-or-later.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GFDL-1.3-invariants-or-later.template.txt"),
        StandardLicenseHeader = ReadResource("GFDL-1.3-invariants-or-later.header.txt"),
        Comment = "This license was released 3 November 2008. The identifier GFDL-1.3-or-later-invariants should only be used when there are Invariant Sections, Front-Cover Texts or Back-Cover Texts. See GFDL-1.3-or-later and GFDL-1.3-or-later-no-invariants for alternatives.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense ARPHIC_1999 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Arphic-1999"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://ftp.gnu.org/gnu/non-gnu/chinese-fonts-truetype/LICENSE")
        ],
        LicenseText = ReadResource("Arphic-1999.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Arphic-1999.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense NPOSL_3_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/NPOSL-3.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/NOSL3.0")
        ],
        LicenseText = ReadResource("NPOSL-3.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("NPOSL-3.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_SA_3_0_AT = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-SA-3.0-AT"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by-sa/3.0/at/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-SA-3.0-AT.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-SA-3.0-AT.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense MPL_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/MPL-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.mozilla.org/MPL/MPL-1.0.html"),
            new Uri("https://opensource.org/licenses/MPL-1.0")
        ],
        LicenseText = ReadResource("MPL-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("MPL-1.0.template.txt"),
        StandardLicenseHeader = ReadResource("MPL-1.0.header.txt"),
        Comment = "This license has been superseded by v1.1",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LGPL_3_0_ONLY = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/LGPL-3.0-only"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/lgpl-3.0-standalone.html"),
            new Uri("https://www.gnu.org/licenses/lgpl+gpl-3.0.txt"),
            new Uri("https://opensource.org/licenses/LGPL-3.0")
        ],
        LicenseText = ReadResource("LGPL-3.0-only.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("LGPL-3.0-only.template.txt"),
        Comment = "This license was released: 29 June 2007. This refers to when only this version of the LGPL is used (as opposed to \"or later\"). The markup includes the GPL-3.0 text as optional text, because the LGPL-3.0 is structured as a supplement to the terms of GPL-3.0.",
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OLDAP_2_5 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OLDAP-2.5"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.openldap.org/devel/gitweb.cgi?p=openldap.git;a=blob;f=LICENSE;hb=6852b9d90022e8593c98205413380536b1b5a7cf")
        ],
        LicenseText = ReadResource("OLDAP-2.5.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OLDAP-2.5.template.txt"),
        Comment = "This license was released 11 May 2001.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OAR = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OAR"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://sourceware.org/git/?p=newlib-cygwin.git;a=blob;f=newlib/libc/string/strsignal.c;hb=HEAD#l35")
        ],
        LicenseText = ReadResource("OAR.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OAR.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SSH_OPENSSH = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/SSH-OpenSSH"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/openssh/openssh-portable/blob/1b11ea7c58cd5c59838b5fa574cd456d6047b2d4/LICENCE#L10")
        ],
        LicenseText = ReadResource("SSH-OpenSSH.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("SSH-OpenSSH.template.txt"),
        Comment = "This a longer version of SSH-short which includes various comments from the OpenSSH developers.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GLULXE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Glulxe"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/Glulxe")
        ],
        LicenseText = ReadResource("Glulxe.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Glulxe.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense MIT_WU = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/MIT-Wu"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/chromium/octane/blob/master/crypto.js")
        ],
        LicenseText = ReadResource("MIT-Wu.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("MIT-Wu.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BSD_4_CLAUSE_SHORTENED = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/BSD-4-Clause-Shortened"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://metadata.ftp-master.debian.org/changelogs//main/a/arpwatch/arpwatch_2.1a15-7_copyright")
        ],
        LicenseText = ReadResource("BSD-4-Clause-Shortened.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("BSD-4-Clause-Shortened.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense UNICODE_TOU = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Unicode-TOU"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://web.archive.org/web/20140704074106/http://www.unicode.org/copyright.html"),
            new Uri("http://www.unicode.org/copyright.html")
        ],
        LicenseText = ReadResource("Unicode-TOU.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Unicode-TOU.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense ELASTIC_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Elastic-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.elastic.co/licensing/elastic-license"),
            new Uri("https://github.com/elastic/elasticsearch/blob/master/licenses/ELASTIC-LICENSE-2.0.txt")
        ],
        LicenseText = ReadResource("Elastic-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Elastic-2.0.template.txt"),
        Comment = "This license was released on February 3, 2021",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_SA_3_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-SA-3.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by-sa/3.0/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-SA-3.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-SA-3.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LGPL_2_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/LGPL-2.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/old-licenses/lgpl-2.1-standalone.html"),
            new Uri("https://opensource.org/licenses/LGPL-2.1")
        ],
        LicenseText = ReadResource("LGPL-2.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("LGPL-2.1.template.txt"),
        StandardLicenseHeader = ReadResource("LGPL-2.1.header.txt"),
        IsFsfLibre = true,
        IsOsiApproved = true,
        IsDeprecatedLicenseId = true,
        DeprecatedVersion = "3.0",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense ZPL_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/ZPL-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://old.zope.org/Resources/License/ZPL-2.0"),
            new Uri("https://opensource.org/licenses/ZPL-2.0")
        ],
        LicenseText = ReadResource("ZPL-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("ZPL-2.0.template.txt"),
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LPPL_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/LPPL-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.latex-project.org/lppl/lppl-1-0.txt")
        ],
        LicenseText = ReadResource("LPPL-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("LPPL-1.0.template.txt"),
        StandardLicenseHeader = ReadResource("LPPL-1.0.header.txt"),
        Comment = "This license was released 1 Mar 1999",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BITTORRENT_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/BitTorrent-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://sources.gentoo.org/cgi-bin/viewvc.cgi/gentoo-x86/licenses/BitTorrent?r1=1.1&r2=1.1.1.1&diff_format=s")
        ],
        LicenseText = ReadResource("BitTorrent-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("BitTorrent-1.0.template.txt"),
        StandardLicenseHeader = ReadResource("BitTorrent-1.0.header.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OGC_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OGC-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.ogc.org/ogc/software/1.0")
        ],
        LicenseText = ReadResource("OGC-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OGC-1.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense ANY_OSI_PERL_MODULES = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/any-OSI-perl-modules"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://metacpan.org/release/JUERD/Exporter-Tidy-0.09/view/Tidy.pm#LICENSE"),
            new Uri("https://metacpan.org/pod/Qmail::Deliverable::Client#LICENSE"),
            new Uri("https://metacpan.org/pod/Net::MQTT::Simple#LICENSE")
        ],
        LicenseText = ReadResource("any-OSI-perl-modules.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("any-OSI-perl-modules.template.txt"),
        Comment = "This is similar in spirit to any-OSI, but has some more specific text. It is used in several Perl modules.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BSD_SYSTEMICS_W3WORKS = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/BSD-Systemics-W3Works"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://metacpan.org/release/DPARIS/Crypt-Blowfish-2.14/source/COPYRIGHT#L7")
        ],
        LicenseText = ReadResource("BSD-Systemics-W3Works.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("BSD-Systemics-W3Works.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense IPL_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/IPL-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/IPL-1.0")
        ],
        LicenseText = ReadResource("IPL-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("IPL-1.0.template.txt"),
        Comment = "This license was superseded by CPL.",
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_NC_ND_2_5 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-NC-ND-2.5"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by-nc-nd/2.5/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-NC-ND-2.5.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-NC-ND-2.5.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GPL_2_0_WITH_FONT_EXCEPTION = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GPL-2.0-with-font-exception"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/gpl-faq.html#FontException")
        ],
        LicenseText = ReadResource("GPL-2.0-with-font-exception.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GPL-2.0-with-font-exception.template.txt"),
        Comment = "DEPRECATED: Use license expression including main license, \"WITH\" operator, and identifier: Font-exception-2.0",
        IsDeprecatedLicenseId = true,
        DeprecatedVersion = "2.0rc2",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense COMMUNITY_SPEC_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Community-Spec-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/CommunitySpecification/1.0/blob/master/1._Community_Specification_License-v1.md")
        ],
        LicenseText = ReadResource("Community-Spec-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Community-Spec-1.0.template.txt"),
        Comment = "Supporting materials are available at https://github.com/CommunitySpecification/1.0.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SENDMAIL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Sendmail"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.sendmail.com/pdfs/open_source/sendmail_license.pdf"),
            new Uri("https://web.archive.org/web/20160322142305/https://www.sendmail.com/pdfs/open_source/sendmail_license.pdf")
        ],
        LicenseText = ReadResource("Sendmail.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Sendmail.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense HTMLTIDY = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/HTMLTIDY"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/htacg/tidy-html5/blob/next/README/LICENSE.md")
        ],
        LicenseText = ReadResource("HTMLTIDY.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("HTMLTIDY.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CNRI_JYTHON = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CNRI-Jython"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.jython.org/license.html")
        ],
        LicenseText = ReadResource("CNRI-Jython.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CNRI-Jython.template.txt"),
        Comment = "This is very similar to CNRI-Python (also on this list), but for an extra clause covering restrictions on trademark and use of the name.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BEERWARE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Beerware"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/Beerware"),
            new Uri("https://people.freebsd.org/~phk/")
        ],
        LicenseText = ReadResource("Beerware.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Beerware.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BSD_3_CLAUSE_OPEN_MPI = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/BSD-3-Clause-Open-MPI"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.open-mpi.org/community/license.php"),
            new Uri("http://www.netlib.org/lapack/LICENSE.txt")
        ],
        LicenseText = ReadResource("BSD-3-Clause-Open-MPI.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("BSD-3-Clause-Open-MPI.template.txt"),
        Comment = "This license is largely similar to BSD-3-Clause, but notably includes an additional paragraph between the three main clauses and the all-caps disclaimer text.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense UCAR = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/UCAR"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/Unidata/UDUNITS-2/blob/master/COPYRIGHT")
        ],
        LicenseText = ReadResource("UCAR.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("UCAR.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GUTMANN = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Gutmann"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.cs.auckland.ac.nz/~pgut001/dumpasn1.c")
        ],
        LicenseText = ReadResource("Gutmann.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Gutmann.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OLDAP_1_3 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OLDAP-1.3"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.openldap.org/devel/gitweb.cgi?p=openldap.git;a=blob;f=LICENSE;hb=e5f8117f0ce088d0bd7a8e18ddf37eaa40eb09b1")
        ],
        LicenseText = ReadResource("OLDAP-1.3.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OLDAP-1.3.template.txt"),
        Comment = "This license was released 17 January 1999. This license was issued twice in the same day with a minor correction. This is the corrected (second) version.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GRAPHICS_GEMS = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Graphics-Gems"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/erich666/GraphicsGems/blob/master/LICENSE.md")
        ],
        LicenseText = ReadResource("Graphics-Gems.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Graphics-Gems.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OGDL_TAIWAN_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OGDL-Taiwan-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://data.gov.tw/license")
        ],
        LicenseText = ReadResource("OGDL-Taiwan-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OGDL-Taiwan-1.0.template.txt"),
        Comment = "Both the Chinese and English translations of this license have been included in the markup.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LILIQ_P_1_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/LiLiQ-P-1.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://forge.gouv.qc.ca/licence/fr/liliq-v1-1/"),
            new Uri("http://opensource.org/licenses/LiLiQ-P-1.1")
        ],
        LicenseText = ReadResource("LiLiQ-P-1.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("LiLiQ-P-1.1.template.txt"),
        Comment = "French is the canonical language for this license. An English translation is provided here: https://forge.gouv.qc.ca/licence/en/liliq-v1-1/#permissive-liliq-p",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SISSL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/SISSL"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.openoffice.org/licenses/sissl_license.html"),
            new Uri("https://opensource.org/licenses/SISSL")
        ],
        LicenseText = ReadResource("SISSL.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("SISSL.template.txt"),
        StandardLicenseHeader = ReadResource("SISSL.header.txt"),
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense NRL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/NRL"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://web.mit.edu/network/isakmp/nrllicense.html")
        ],
        LicenseText = ReadResource("NRL.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("NRL.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense MCPHEE_SLIDESHOW = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/McPhee-slideshow"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://mirror.las.iastate.edu/tex-archive/graphics/metapost/contrib/macros/slideshow/slideshow.mp")
        ],
        LicenseText = ReadResource("McPhee-slideshow.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("McPhee-slideshow.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense UPL_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/UPL-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/UPL")
        ],
        LicenseText = ReadResource("UPL-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("UPL-1.0.template.txt"),
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense XEROX = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Xerox"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/Xerox")
        ],
        LicenseText = ReadResource("Xerox.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Xerox.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense TPL_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/TPL-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing:ThorPublicLicense")
        ],
        LicenseText = ReadResource("TPL-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("TPL-1.0.template.txt"),
        StandardLicenseHeader = ReadResource("TPL-1.0.header.txt"),
        Comment = "This license is the same as MPL-1.1 (and CUA-OPL-1.0) except for the name and the choice of law (Germany, instead of California)",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense ZED = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Zed"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/Zed")
        ],
        LicenseText = ReadResource("Zed.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Zed.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense UCL_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/UCL-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/UCL-1.0")
        ],
        LicenseText = ReadResource("UCL-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("UCL-1.0.template.txt"),
        StandardLicenseHeader = ReadResource("UCL-1.0.header.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense ADSL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/ADSL"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/AmazonDigitalServicesLicense")
        ],
        LicenseText = ReadResource("ADSL.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("ADSL.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense IJG = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/IJG"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://dev.w3.org/cvsweb/Amaya/libjpeg/Attic/README?rev=1.2")
        ],
        LicenseText = ReadResource("IJG.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("IJG.template.txt"),
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SAX_PD = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/SAX-PD"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.saxproject.org/copying.html")
        ],
        LicenseText = ReadResource("SAX-PD.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("SAX-PD.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense AGPL_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/AGPL-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.affero.org/oagpl.html")
        ],
        LicenseText = ReadResource("AGPL-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("AGPL-1.0.template.txt"),
        Comment = "DEPRECATED: Use the license identifier AGPL-1.0-only instead of AGPL-1.0.\n\n",
        IsFsfLibre = true,
        IsOsiApproved = false,
        IsDeprecatedLicenseId = true,
        DeprecatedVersion = "3.1",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SCHEMEREPORT = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/SchemeReport"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
        ],
        LicenseText = ReadResource("SchemeReport.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("SchemeReport.template.txt"),
        Comment = "Code derived from the document \"Revised Report on Scheme\" and subsequent revisions, is distributed under the following license:\n\n",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense PHP_3_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/PHP-3.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.php.net/license/3_0.txt"),
            new Uri("https://opensource.org/licenses/PHP-3.0")
        ],
        LicenseText = ReadResource("PHP-3.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("PHP-3.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LGPLLR = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/LGPLLR"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www-igm.univ-mlv.fr/~unitex/lgpllr.html")
        ],
        LicenseText = ReadResource("LGPLLR.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("LGPLLR.template.txt"),
        Comment = "Appears to have borrowed some language from the LGPL-2.1.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense TMATE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/TMate"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://svnkit.com/license.html")
        ],
        LicenseText = ReadResource("TMate.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("TMate.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CDLA_SHARING_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CDLA-Sharing-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://cdla.io/sharing-1-0")
        ],
        LicenseText = ReadResource("CDLA-Sharing-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CDLA-Sharing-1.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense HPND_PBMPLUS = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/HPND-Pbmplus"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://sourceforge.net/p/netpbm/code/HEAD/tree/super_stable/netpbm.c#l8")
        ],
        LicenseText = ReadResource("HPND-Pbmplus.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("HPND-Pbmplus.template.txt"),
        Comment = "This license is nearly a match for HPND, but omits first sentence of third clause regarding no reps, and only includes the second sentence regarding \"as is\". In the original HPND that entire clause is optional.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense DOCBOOK_SCHEMA = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/DocBook-Schema"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/docbook/xslt10-stylesheets/blob/efd62655c11cc8773708df7a843613fa1e932bf8/xsl/assembly/schema/docbook51b7.rnc")
        ],
        LicenseText = ReadResource("DocBook-Schema.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("DocBook-Schema.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GFDL_1_2 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GFDL-1.2"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/old-licenses/fdl-1.2.txt")
        ],
        LicenseText = ReadResource("GFDL-1.2.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GFDL-1.2.template.txt"),
        StandardLicenseHeader = ReadResource("GFDL-1.2.header.txt"),
        IsFsfLibre = true,
        IsOsiApproved = false,
        IsDeprecatedLicenseId = true,
        DeprecatedVersion = "3.0",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_NC_SA_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-NC-SA-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by-nc-sa/1.0/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-NC-SA-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-NC-SA-1.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SUN_PPP_2000 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Sun-PPP-2000"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/ppp-project/ppp/blob/master/modules/ppp_ahdlc.c#L7-L19")
        ],
        LicenseText = ReadResource("Sun-PPP-2000.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Sun-PPP-2000.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GFDL_1_3_INVARIANTS_ONLY = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GFDL-1.3-invariants-only"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/fdl-1.3.txt")
        ],
        LicenseText = ReadResource("GFDL-1.3-invariants-only.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GFDL-1.3-invariants-only.template.txt"),
        StandardLicenseHeader = ReadResource("GFDL-1.3-invariants-only.header.txt"),
        Comment = "This license was released 3 November 2008. The identifier GFDL-1.3-only-invariants should only be used when there are Invariant Sections, Front-Cover Texts or Back-Cover Texts. See GFDL-1.3-only and GFDL-1.3-only-no-invariants for alternatives.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense AFL_3_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/AFL-3.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.rosenlaw.com/AFL3.0.htm"),
            new Uri("https://opensource.org/licenses/afl-3.0")
        ],
        LicenseText = ReadResource("AFL-3.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("AFL-3.0.template.txt"),
        StandardLicenseHeader = ReadResource("AFL-3.0.header.txt"),
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense YPL_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/YPL-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.zimbra.com/license/yahoo_public_license_1.0.html")
        ],
        LicenseText = ReadResource("YPL-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("YPL-1.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense ISC = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/ISC"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.isc.org/licenses/"),
            new Uri("https://www.isc.org/downloads/software-support-policy/isc-license/"),
            new Uri("https://opensource.org/licenses/ISC")
        ],
        LicenseText = ReadResource("ISC.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("ISC.template.txt"),
        Comment = "The ISC License text changed 'and' to 'and/or' in July 2007.",
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CALDERA_NO_PREAMBLE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Caldera-no-preamble"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/apache/apr/blob/trunk/LICENSE#L298C6-L298C29")
        ],
        LicenseText = ReadResource("Caldera-no-preamble.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Caldera-no-preamble.template.txt"),
        Comment = "This is identical to Caldera License, but does not include first paragraph.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OLDAP_2_8 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OLDAP-2.8"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.openldap.org/software/release/license.html")
        ],
        LicenseText = ReadResource("OLDAP-2.8.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OLDAP-2.8.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LINUX_OPENIB = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Linux-OpenIB"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://git.kernel.org/pub/scm/linux/kernel/git/torvalds/linux.git/tree/drivers/infiniband/core/sa.h")
        ],
        LicenseText = ReadResource("Linux-OpenIB.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Linux-OpenIB.template.txt"),
        Comment = "This license is BSD-2-Clause with the MIT disclaimer. The linux kernel uses this license extensively throughout the driver subsystem since 2005. Note that the OpenIB.org license is a true match to BSD-2-Clause.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense AGPL_1_0_OR_LATER = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/AGPL-1.0-or-later"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.affero.org/oagpl.html")
        ],
        LicenseText = ReadResource("AGPL-1.0-or-later.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("AGPL-1.0-or-later.template.txt"),
        Comment = "Section 9 of this license allows content under this \"any later version\" grant to be redistributed under the GPL-3.0-or-later. Affero Inc. also released an AGPL-2.0 (http://www.affero.org/agpl2.html) to allow AGPL-1.0-or-later work to be distributed under the AGPL-3.0-or-later.\n\n",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense PKGCONF = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/pkgconf"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/pkgconf/pkgconf/blob/master/cli/main.c#L8")
        ],
        LicenseText = ReadResource("pkgconf.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("pkgconf.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GPL_3_0_ = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GPL-3.0+"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/gpl-3.0-standalone.html"),
            new Uri("https://opensource.org/licenses/GPL-3.0")
        ],
        LicenseText = ReadResource("GPL-3.0+.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GPL-3.0+.template.txt"),
        StandardLicenseHeader = ReadResource("GPL-3.0+.header.txt"),
        IsFsfLibre = true,
        IsOsiApproved = true,
        IsDeprecatedLicenseId = true,
        DeprecatedVersion = "2.0rc2",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OPENPBS_2_3 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OpenPBS-2.3"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/adaptivecomputing/torque/blob/master/PBS_License.txt"),
            new Uri("https://www.mcs.anl.gov/research/projects/openpbs/PBS_License.txt")
        ],
        LicenseText = ReadResource("OpenPBS-2.3.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OpenPBS-2.3.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CROSSWORD = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Crossword"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/Crossword")
        ],
        LicenseText = ReadResource("Crossword.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Crossword.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense NTIA_PD = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/NTIA-PD"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://raw.githubusercontent.com/NTIA/itm/refs/heads/master/LICENSE.md"),
            new Uri("https://raw.githubusercontent.com/NTIA/scos-sensor/refs/heads/master/LICENSE.md")
        ],
        LicenseText = ReadResource("NTIA-PD.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("NTIA-PD.template.txt"),
        Comment = "The public domain dedication text is very similar to 'NIST-PD' but this license is for a different US federal org (NTIA) and adds a fall-back license grant.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LAL_1_3 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/LAL-1.3"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://artlibre.org/")
        ],
        LicenseText = ReadResource("LAL-1.3.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("LAL-1.3.template.txt"),
        Comment = "French is the canonical language for this license. Translations are available in: English: https://artlibre.org/licence/lal/en/ Portuguese: https://artlibre.org/licence/lal/pt/ Polish: https://artlibre.org/licence/lal/pl/",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense HPND_MIT_DISCLAIMER = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/HPND-MIT-disclaimer"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://metacpan.org/release/NLNETLABS/Net-DNS-SEC-1.22/source/LICENSE")
        ],
        LicenseText = ReadResource("HPND-MIT-disclaimer.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("HPND-MIT-disclaimer.template.txt"),
        Comment = "This is essentially HPND with the disclaimer from MIT license.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense AMD_NEWLIB = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/AMD-newlib"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://sourceware.org/git/?p=newlib-cygwin.git;a=blob;f=newlib/libc/sys/a29khif/_close.S;h=04f52ae00de1dafbd9055ad8d73c5c697a3aae7f;hb=HEAD")
        ],
        LicenseText = ReadResource("AMD-newlib.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("AMD-newlib.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CNRI_PYTHON = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CNRI-Python"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/CNRI-Python")
        ],
        LicenseText = ReadResource("CNRI-Python.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CNRI-Python.template.txt"),
        Comment = "CNRI portion of the multi-part Python License (Python-2.0)",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LPD_DOCUMENT = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/LPD-document"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/Cyan4973/xxHash/blob/dev/doc/xxhash_spec.md"),
            new Uri("https://www.ietf.org/rfc/rfc1952.txt")
        ],
        LicenseText = ReadResource("LPD-document.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("LPD-document.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense QPL_1_0_INRIA_2004 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/QPL-1.0-INRIA-2004"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/maranget/hevea/blob/master/LICENSE")
        ],
        LicenseText = ReadResource("QPL-1.0-INRIA-2004.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("QPL-1.0-INRIA-2004.template.txt"),
        Comment = "This license is a variant of QPL-1.0 with the choice of law changed to France. This variant appears to be generally used together with QPL-1.0-INRIA-2004-exception.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SPENCER_86 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Spencer-86"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/Henry_Spencer_Reg-Ex_Library_License")
        ],
        LicenseText = ReadResource("Spencer-86.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Spencer-86.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense APACHE_1_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Apache-1.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://apache.org/licenses/LICENSE-1.1"),
            new Uri("https://opensource.org/licenses/Apache-1.1")
        ],
        LicenseText = ReadResource("Apache-1.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Apache-1.1.template.txt"),
        Comment = "This license has been superseded by Apache License 2.0",
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense HPND_UC = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/HPND-UC"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://core.tcl-lang.org/tk/file?name=compat/unistd.h")
        ],
        LicenseText = ReadResource("HPND-UC.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("HPND-UC.template.txt"),
        Comment = "This license is similar to HPND but omits the obligation that the copyright notice and this permission notice appear in supporting documentation.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense NET_SNMP = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Net-SNMP"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://net-snmp.sourceforge.net/about/license.html")
        ],
        LicenseText = ReadResource("Net-SNMP.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Net-SNMP.template.txt"),
        Comment = "DEPRECATED: The Net-SNMP license id represented the license stack of 9 licenses found at https://net-snmp.sourceforge.io/about/license.html and net-snmp-5.6.2. Since then, more licenses have been added. Retaining this license id could consequently cause confusion and all of the licenses in the stack are already on the SPDX License List, thus can be identified with an SPDX license expression.",
        IsDeprecatedLicenseId = true,
        DeprecatedVersion = "3.25.0",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense HDPARM = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/hdparm"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/Distrotech/hdparm/blob/4517550db29a91420fb2b020349523b1b4512df2/LICENSE.TXT")
        ],
        LicenseText = ReadResource("hdparm.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("hdparm.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense MULTICS = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Multics"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/Multics")
        ],
        LicenseText = ReadResource("Multics.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Multics.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense APSL_1_2 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/APSL-1.2"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.samurajdata.se/opensource/mirror/licenses/apsl.php")
        ],
        LicenseText = ReadResource("APSL-1.2.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("APSL-1.2.template.txt"),
        Comment = "This license was released 4 Jan 2001.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense DTOA = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/dtoa"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/SWI-Prolog/swipl-devel/blob/master/src/os/dtoa.c"),
            new Uri("https://sourceware.org/git/?p=newlib-cygwin.git;a=blob;f=newlib/libc/stdlib/mprec.h;hb=HEAD")
        ],
        LicenseText = ReadResource("dtoa.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("dtoa.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GSOAP_1_3B = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/gSOAP-1.3b"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.cs.fsu.edu/~engelen/license.html")
        ],
        LicenseText = ReadResource("gSOAP-1.3b.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("gSOAP-1.3b.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SGI_B_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/SGI-B-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://oss.sgi.com/projects/FreeB/SGIFreeSWLicB.1.0.html")
        ],
        LicenseText = ReadResource("SGI-B-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("SGI-B-1.0.template.txt"),
        StandardLicenseHeader = ReadResource("SGI-B-1.0.header.txt"),
        Comment = "This license was released 25 January 2000",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense AGPL_3_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/AGPL-3.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/agpl.txt"),
            new Uri("https://opensource.org/licenses/AGPL-3.0")
        ],
        LicenseText = ReadResource("AGPL-3.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("AGPL-3.0.template.txt"),
        StandardLicenseHeader = ReadResource("AGPL-3.0.header.txt"),
        IsFsfLibre = true,
        IsOsiApproved = true,
        IsDeprecatedLicenseId = true,
        DeprecatedVersion = "3.0",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GL2PS = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GL2PS"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.geuz.org/gl2ps/COPYING.GL2PS")
        ],
        LicenseText = ReadResource("GL2PS.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GL2PS.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CUBE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Cube"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/Cube")
        ],
        LicenseText = ReadResource("Cube.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Cube.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense HPND_EXPORT_US = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/HPND-export-US"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.kermitproject.org/ck90.html#source")
        ],
        LicenseText = ReadResource("HPND-export-US.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("HPND-export-US.template.txt"),
        Comment = "This license is found in the Kermit project. It is similar to HPND, with an additional initial statement regarding export control laws.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SNIA = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/SNIA"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/SNIA_Public_License")
        ],
        LicenseText = ReadResource("SNIA.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("SNIA.template.txt"),
        Comment = "This is MPL-1.1 with some edits.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GPL_2_0_WITH_CLASSPATH_EXCEPTION = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GPL-2.0-with-classpath-exception"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/software/classpath/license.html")
        ],
        LicenseText = ReadResource("GPL-2.0-with-classpath-exception.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GPL-2.0-with-classpath-exception.template.txt"),
        Comment = "DEPRECATED: Use license expression including main license, \"WITH\" operator, and identifier: Classpath-exception-2.0",
        IsDeprecatedLicenseId = true,
        DeprecatedVersion = "2.0rc2",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense JASPER_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/JasPer-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.ece.uvic.ca/~mdadams/jasper/LICENSE")
        ],
        LicenseText = ReadResource("JasPer-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("JasPer-2.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense APACHE_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Apache-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.apache.org/licenses/LICENSE-2.0"),
            new Uri("https://opensource.org/licenses/Apache-2.0")
        ],
        LicenseText = ReadResource("Apache-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Apache-2.0.template.txt"),
        StandardLicenseHeader = ReadResource("Apache-2.0.header.txt"),
        Comment = "This license was released January 2004",
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense TTYP0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/TTYP0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://people.mpi-inf.mpg.de/~uwe/misc/uw-ttyp0/")
        ],
        LicenseText = ReadResource("TTYP0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("TTYP0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/SL"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/mtoyoda/sl/blob/master/LICENSE")
        ],
        LicenseText = ReadResource("SL.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("SL.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LPPL_1_3A = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/LPPL-1.3a"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.latex-project.org/lppl/lppl-1-3a.txt")
        ],
        LicenseText = ReadResource("LPPL-1.3a.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("LPPL-1.3a.template.txt"),
        StandardLicenseHeader = ReadResource("LPPL-1.3a.header.txt"),
        Comment = "This license was released 1 Oct 2004",
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense AFL_1_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/AFL-1.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://opensource.linux-mirror.org/licenses/afl-1.1.txt"),
            new Uri("http://wayback.archive.org/web/20021004124254/http://www.opensource.org/licenses/academic.php")
        ],
        LicenseText = ReadResource("AFL-1.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("AFL-1.1.template.txt"),
        StandardLicenseHeader = ReadResource("AFL-1.1.header.txt"),
        Comment = "This license has been superseded by later versions.",
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OPENVISION = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OpenVision"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/krb5/krb5/blob/krb5-1.21.2-final/NOTICE#L66-L98"),
            new Uri("https://web.mit.edu/kerberos/krb5-1.21/doc/mitK5license.html"),
            new Uri("https://fedoraproject.org/wiki/Licensing:MIT#OpenVision_Variant")
        ],
        LicenseText = ReadResource("OpenVision.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OpenVision.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LGPL_2_1_ONLY = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/LGPL-2.1-only"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/old-licenses/lgpl-2.1-standalone.html"),
            new Uri("https://opensource.org/licenses/LGPL-2.1")
        ],
        LicenseText = ReadResource("LGPL-2.1-only.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("LGPL-2.1-only.template.txt"),
        StandardLicenseHeader = ReadResource("LGPL-2.1-only.header.txt"),
        Comment = "This license was released: February 1999. This license identifier refers to the choice to use the code under LGPL-2.1-only, as distinguished from use of code under LGPL-2.1-or-later (i.e., LGPL-2.1 or some later version). The license notice (as seen in the Standard License Header field below) states which of these applies to the code in the file. The example in the exhibit to the license shows the license notice for the \"or later\" approach.",
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense ODC_BY_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/ODC-By-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opendatacommons.org/licenses/by/1.0/")
        ],
        LicenseText = ReadResource("ODC-By-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("ODC-By-1.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense APSL_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/APSL-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.opensource.apple.com/license/apsl/")
        ],
        LicenseText = ReadResource("APSL-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("APSL-2.0.template.txt"),
        StandardLicenseHeader = ReadResource("APSL-2.0.header.txt"),
        Comment = "This license was released: 6 August 2003.",
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_NC_SA_3_0_IGO = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-NC-SA-3.0-IGO"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by-nc-sa/3.0/igo/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-NC-SA-3.0-IGO.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-NC-SA-3.0-IGO.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense FSFULLRWD = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/FSFULLRWD"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://lists.gnu.org/archive/html/autoconf/2012-04/msg00061.html")
        ],
        LicenseText = ReadResource("FSFULLRWD.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("FSFULLRWD.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SGP4 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/SGP4"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://celestrak.org/publications/AIAA/2006-6753/faq.php")
        ],
        LicenseText = ReadResource("SGP4.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("SGP4.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense WXWINDOWS = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/wxWindows"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/WXwindows")
        ],
        LicenseText = ReadResource("wxWindows.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("wxWindows.template.txt"),
        Comment = "DEPRECATED: Use license expression including main license, \"WITH\" operator, and identifier: WxWindows-exception-3.1",
        IsDeprecatedLicenseId = true,
        DeprecatedVersion = "2.0rc2",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_SA_2_0_UK = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-SA-2.0-UK"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by-sa/2.0/uk/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-SA-2.0-UK.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-SA-2.0-UK.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OLDAP_2_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OLDAP-2.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.openldap.org/devel/gitweb.cgi?p=openldap.git;a=blob;f=LICENSE;hb=b0d176738e96a0d3b9f85cb51e140a86f21be715")
        ],
        LicenseText = ReadResource("OLDAP-2.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OLDAP-2.1.template.txt"),
        Comment = "This license was released 29 February 2000.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LUCIDA_BITMAP_FONTS = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Lucida-Bitmap-Fonts"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://gitlab.freedesktop.org/xorg/font/bh-100dpi/-/blob/master/COPYING?ref_type=heads")
        ],
        LicenseText = ReadResource("Lucida-Bitmap-Fonts.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Lucida-Bitmap-Fonts.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LGPL_2_0_ = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/LGPL-2.0+"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/old-licenses/lgpl-2.0-standalone.html")
        ],
        LicenseText = ReadResource("LGPL-2.0+.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("LGPL-2.0+.template.txt"),
        StandardLicenseHeader = ReadResource("LGPL-2.0+.header.txt"),
        IsDeprecatedLicenseId = true,
        DeprecatedVersion = "2.0rc2",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense ENTESSA = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Entessa"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/Entessa")
        ],
        LicenseText = ReadResource("Entessa.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Entessa.template.txt"),
        Comment = "This license is mostly a match to Apache-1.1 (except for the addition of \"open source\" before \"software\" in the clause 3 acknowledgement, and different text in the last paragraph, which is optional in Apache-1.1. It has its own entry on the SPDX License List due to the OSI having approved it.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BSD_3_CLAUSE_ACPICA = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/BSD-3-Clause-acpica"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/acpica/acpica/blob/master/source/common/acfileio.c#L119")
        ],
        LicenseText = ReadResource("BSD-3-Clause-acpica.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("BSD-3-Clause-acpica.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense NIST_PD_FALLBACK = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/NIST-PD-fallback"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/usnistgov/jsip/blob/59700e6926cbe96c5cdae897d9a7d2656b42abe3/LICENSE"),
            new Uri("https://github.com/usnistgov/fipy/blob/86aaa5c2ba2c6f1be19593c5986071cf6568cc34/LICENSE.rst")
        ],
        LicenseText = ReadResource("NIST-PD-fallback.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("NIST-PD-fallback.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OFL_1_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OFL-1.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://scripts.sil.org/cms/scripts/page.php?item_id=OFL_web"),
            new Uri("https://opensource.org/licenses/OFL-1.1")
        ],
        LicenseText = ReadResource("OFL-1.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OFL-1.1.template.txt"),
        Comment = "This license was released 26 February 2007. The identifier OFL-1.1 can be used to indicate that version 1.1 of the SIL Open Font License applies, without asserting whether or not a Reserved Font Name is used. See OFL-1.1-RFN and OFL-1.1-no-RFN for alternative identifiers that can be used to express explicitly that a Reserved Font Name is used or is not used, respectively.",
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CECILL_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CECILL-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.cecill.info/licences/Licence_CeCILL_V2-en.html")
        ],
        LicenseText = ReadResource("CECILL-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CECILL-2.0.template.txt"),
        Comment = "French version can be found here: http://www.cecill.info/licences/Licence_CeCILL_V2-fr.html",
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense TU_BERLIN_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/TU-Berlin-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/swh/ladspa/blob/7bf6f3799fdba70fda297c2d8fd9f526803d9680/gsm/COPYRIGHT")
        ],
        LicenseText = ReadResource("TU-Berlin-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("TU-Berlin-1.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense MPL_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/MPL-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.mozilla.org/MPL/2.0/"),
            new Uri("https://opensource.org/licenses/MPL-2.0")
        ],
        LicenseText = ReadResource("MPL-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("MPL-2.0.template.txt"),
        StandardLicenseHeader = ReadResource("MPL-2.0.header.txt"),
        Comment = "This license was released in January 2012. This license list entry is for use when the standard MPL 2.0 is used, as indicated by the standard header (Exhibit A but no Exhibit B).",
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense HPND_FENNEBERG_LIVINGSTON = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/HPND-Fenneberg-Livingston"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/FreeRADIUS/freeradius-client/blob/master/COPYRIGHT#L32"),
            new Uri("https://github.com/radcli/radcli/blob/master/COPYRIGHT#L34")
        ],
        LicenseText = ReadResource("HPND-Fenneberg-Livingston.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("HPND-Fenneberg-Livingston.template.txt"),
        Comment = "This is similar to HPND but adds an obligation relating notice in supporting documentation.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OFL_1_1_NO_RFN = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OFL-1.1-no-RFN"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://scripts.sil.org/cms/scripts/page.php?item_id=OFL_web"),
            new Uri("https://opensource.org/licenses/OFL-1.1")
        ],
        LicenseText = ReadResource("OFL-1.1-no-RFN.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OFL-1.1-no-RFN.template.txt"),
        Comment = "This license was released 26 February 2007. The identifier OFL-1.1-no-RFN should only be used when there is no Reserved Font Name. See OFL-1.1 and OFL-1.1-RFN for alternatives.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense NCL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/NCL"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://gitlab.freedesktop.org/pipewire/pipewire/-/blob/master/src/modules/module-filter-chain/pffft.c?ref_type=heads#L1-52")
        ],
        LicenseText = ReadResource("NCL.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("NCL.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense XDEBUG_1_03 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Xdebug-1.03"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/xdebug/xdebug/blob/master/LICENSE")
        ],
        LicenseText = ReadResource("Xdebug-1.03.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Xdebug-1.03.template.txt"),
        Comment = "This license is based on the PHP License v3.01, but omits the last part of the 4th clause",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense D_FSL_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/D-FSL-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.dipp.nrw.de/d-fsl/lizenzen/"),
            new Uri("http://www.dipp.nrw.de/d-fsl/index_html/lizenzen/de/D-FSL-1_0_de.txt"),
            new Uri("http://www.dipp.nrw.de/d-fsl/index_html/lizenzen/en/D-FSL-1_0_en.txt"),
            new Uri("https://www.hbz-nrw.de/produkte/open-access/lizenzen/dfsl"),
            new Uri("https://www.hbz-nrw.de/produkte/open-access/lizenzen/dfsl/deutsche-freie-software-lizenz"),
            new Uri("https://www.hbz-nrw.de/produkte/open-access/lizenzen/dfsl/german-free-software-license"),
            new Uri("https://www.hbz-nrw.de/produkte/open-access/lizenzen/dfsl/D-FSL-1_0_de.txt/at_download/file"),
            new Uri("https://www.hbz-nrw.de/produkte/open-access/lizenzen/dfsl/D-FSL-1_0_en.txt/at_download/file")
        ],
        LicenseText = ReadResource("D-FSL-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("D-FSL-1.0.template.txt"),
        Comment = "This license was created for and is backed by the German state. The English translation can be found here: http://www.dipp.nrw.de/d-fsl/index_html/lizenzen/en/D-FSL-1_0_en.txt",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OLDAP_1_2 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OLDAP-1.2"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.openldap.org/devel/gitweb.cgi?p=openldap.git;a=blob;f=LICENSE;hb=42b0383c50c299977b5893ee695cf4e486fb0dc7")
        ],
        LicenseText = ReadResource("OLDAP-1.2.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OLDAP-1.2.template.txt"),
        Comment = "This license was released 1 September 1998. This license was issued four time, but only with formatting differences.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense ICU = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/ICU"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://source.icu-project.org/repos/icu/icu/trunk/license.html")
        ],
        LicenseText = ReadResource("ICU.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("ICU.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GPL_3_0_OR_LATER = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GPL-3.0-or-later"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/gpl-3.0-standalone.html"),
            new Uri("https://opensource.org/licenses/GPL-3.0")
        ],
        LicenseText = ReadResource("GPL-3.0-or-later.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GPL-3.0-or-later.template.txt"),
        StandardLicenseHeader = ReadResource("GPL-3.0-or-later.header.txt"),
        Comment = "This license was released: 29 June 2007. This license identifier refers to the choice to use code under GPL-3.0-or-later (i.e., GPL-3.0 or some later version), as distinguished from the use of code under GPL-3.0-only. The license notice (as seen in the Standard License Header field below) states which of these applies to the code in the file. The example in the How to Apply These Terms appendix of the license shows the \"or later\" approach.",
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense URT_RLE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/URT-RLE"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://sourceforge.net/p/netpbm/code/HEAD/tree/super_stable/converter/other/pnmtorle.c"),
            new Uri("https://sourceforge.net/p/netpbm/code/HEAD/tree/super_stable/converter/other/rletopnm.c")
        ],
        LicenseText = ReadResource("URT-RLE.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("URT-RLE.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LOOP = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/LOOP"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://gitlab.com/embeddable-common-lisp/ecl/-/blob/develop/src/lsp/loop.lsp"),
            new Uri("http://git.savannah.gnu.org/cgit/gcl.git/tree/gcl/lsp/gcl_loop.lsp?h=Version_2_6_13pre"),
            new Uri("https://sourceforge.net/p/sbcl/sbcl/ci/master/tree/src/code/loop.lisp"),
            new Uri("https://github.com/cl-adams/adams/blob/master/LICENSE.md"),
            new Uri("https://github.com/blakemcbride/eclipse-lisp/blob/master/lisp/loop.lisp"),
            new Uri("https://gitlab.common-lisp.net/cmucl/cmucl/-/blob/master/src/code/loop.lisp")
        ],
        LicenseText = ReadResource("LOOP.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("LOOP.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OPUBL_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OPUBL-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://opencontent.org/openpub/"),
            new Uri("https://www.debian.org/opl"),
            new Uri("https://www.ctan.org/license/opl")
        ],
        LicenseText = ReadResource("OPUBL-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OPUBL-1.0.template.txt"),
        Comment = "Users of this license may wish to take care to identify which, if any, of the 'license options' described in section VI apply to the licensed work.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GCR_DOCS = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GCR-docs"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/GNOME/gcr/blob/master/docs/COPYING")
        ],
        LicenseText = ReadResource("GCR-docs.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GCR-docs.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense MPLUS = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/mplus"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing:Mplus?rd=Licensing/mplus")
        ],
        LicenseText = ReadResource("mplus.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("mplus.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GFDL_1_2_ONLY = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GFDL-1.2-only"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/old-licenses/fdl-1.2.txt")
        ],
        LicenseText = ReadResource("GFDL-1.2-only.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GFDL-1.2-only.template.txt"),
        StandardLicenseHeader = ReadResource("GFDL-1.2-only.header.txt"),
        Comment = "This license was released November 2002. The identifier GFDL-1.2-only can be used to indicate that this license applies, without asserting whether or not any Invariant Sections, Front-Cover Texts or Back-Cover Texts are present. See GFDL-1.2-only-invariants and GFDL-1.2-only-no-invariants for alternative identifiers that can be used to express explicitly that these sections or cover texts are present or are not present, respectively.",
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense HP_1989 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/HP-1989"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/bleargh45/Data-UUID/blob/master/LICENSE")
        ],
        LicenseText = ReadResource("HP-1989.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("HP-1989.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OPENSSL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OpenSSL"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.openssl.org/source/license.html")
        ],
        LicenseText = ReadResource("OpenSSL.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OpenSSL.template.txt"),
        Comment = "The OpenSSL toolkit stays under a dual license, i.e. both the conditions of the OpenSSL License and the original SSLeay license apply to the toolkit.",
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SUNPRO = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/SunPro"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/freebsd/freebsd-src/blob/main/lib/msun/src/e_acosh.c"),
            new Uri("https://github.com/freebsd/freebsd-src/blob/main/lib/msun/src/e_lgammal.c")
        ],
        LicenseText = ReadResource("SunPro.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("SunPro.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SOFTSURFER = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/softSurfer"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/mm2/Little-CMS/blob/master/src/cmssm.c#L207"),
            new Uri("https://fedoraproject.org/wiki/Licensing/softSurfer")
        ],
        LicenseText = ReadResource("softSurfer.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("softSurfer.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BARR = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Barr"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/Barr")
        ],
        LicenseText = ReadResource("Barr.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Barr.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense HPND_EXPORT2_US = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/HPND-export2-US"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/krb5/krb5/blob/krb5-1.21.2-final/NOTICE#L111-L133"),
            new Uri("https://web.mit.edu/kerberos/krb5-1.21/doc/mitK5license.html")
        ],
        LicenseText = ReadResource("HPND-export2-US.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("HPND-export2-US.template.txt"),
        Comment = "This license is very similar to HPND-export-US, but adds a second disclaimer.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GFDL_1_1_INVARIANTS_ONLY = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GFDL-1.1-invariants-only"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/old-licenses/fdl-1.1.txt")
        ],
        LicenseText = ReadResource("GFDL-1.1-invariants-only.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GFDL-1.1-invariants-only.template.txt"),
        StandardLicenseHeader = ReadResource("GFDL-1.1-invariants-only.header.txt"),
        Comment = "This license was released March 2000. The identifier GFDL-1.1-only-invariants should only be used when there are Invariant Sections, Front-Cover Texts or Back-Cover Texts. See GFDL-1.1-only and GFDL-1.1-only-no-invariants for alternatives.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BSD_3_CLAUSE_MODIFICATION = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/BSD-3-Clause-Modification"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing:BSD#Modification_Variant")
        ],
        LicenseText = ReadResource("BSD-3-Clause-Modification.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("BSD-3-Clause-Modification.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense MIT_TESTREGEX = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/MIT-testregex"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/dotnet/runtime/blob/55e1ac7c07df62c4108d4acedf78f77574470ce5/src/libraries/System.Text.RegularExpressions/tests/FunctionalTests/AttRegexTests.cs#L12-L28")
        ],
        LicenseText = ReadResource("MIT-testregex.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("MIT-testregex.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense ARTISTIC_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Artistic-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.perlfoundation.org/artistic_license_2_0"),
            new Uri("https://www.perlfoundation.org/artistic-license-20.html"),
            new Uri("https://opensource.org/licenses/artistic-license-2.0")
        ],
        LicenseText = ReadResource("Artistic-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Artistic-2.0.template.txt"),
        Comment = "This license was released: 2006",
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CVE_TOU = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/cve-tou"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.cve.org/Legal/TermsOfUse")
        ],
        LicenseText = ReadResource("cve-tou.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("cve-tou.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense PNMSTITCH = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/pnmstitch"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://sourceforge.net/p/netpbm/code/HEAD/tree/super_stable/editor/pnmstitch.c#l2")
        ],
        LicenseText = ReadResource("pnmstitch.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("pnmstitch.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OLDAP_1_4 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OLDAP-1.4"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.openldap.org/devel/gitweb.cgi?p=openldap.git;a=blob;f=LICENSE;hb=c9f95c2f3f2ffb5e0ae55fe7388af75547660941")
        ],
        LicenseText = ReadResource("OLDAP-1.4.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OLDAP-1.4.template.txt"),
        Comment = "This license was released 18 January 1999.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OFL_1_0_RFN = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OFL-1.0-RFN"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://scripts.sil.org/cms/scripts/page.php?item_id=OFL10_web")
        ],
        LicenseText = ReadResource("OFL-1.0-RFN.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OFL-1.0-RFN.template.txt"),
        Comment = "This license has been superseded. This license was released in November 2005. The identifier OFL-1.0-RFN should only be used when a Reserved Font Name applies. See OFL-1.0 and OFL-1.0-no-RFN for alternatives.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BSD_1_CLAUSE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/BSD-1-Clause"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://svnweb.freebsd.org/base/head/include/ifaddrs.h?revision=326823")
        ],
        LicenseText = ReadResource("BSD-1-Clause.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("BSD-1-Clause.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LSOF = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/lsof"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/lsof-org/lsof/blob/master/COPYING")
        ],
        LicenseText = ReadResource("lsof.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("lsof.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense NTP = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/NTP"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/NTP")
        ],
        LicenseText = ReadResource("NTP.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("NTP.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense AMDPLPA = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/AMDPLPA"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/AMD_plpa_map_License")
        ],
        LicenseText = ReadResource("AMDPLPA.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("AMDPLPA.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense PYTHON_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Python-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/Python-2.0")
        ],
        LicenseText = ReadResource("Python-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Python-2.0.template.txt"),
        Comment = "This is the overall Python license as published on the OSI website, which is comprised of several licenses.",
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BAEKMUK = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Baekmuk"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing:Baekmuk?rd=Licensing/Baekmuk")
        ],
        LicenseText = ReadResource("Baekmuk.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Baekmuk.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SSPL_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/SSPL-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.mongodb.com/licensing/server-side-public-license")
        ],
        LicenseText = ReadResource("SSPL-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("SSPL-1.0.template.txt"),
        StandardLicenseHeader = ReadResource("SSPL-1.0.header.txt"),
        Comment = "This license uses much of the text of AGPL-3.0, but with a different clause 13 and 14.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GIFTWARE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Giftware"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://liballeg.org/license.html#allegro-4-the-giftware-license")
        ],
        LicenseText = ReadResource("Giftware.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Giftware.template.txt"),
        Comment = "This license may also be known as Allegro 4. The Allegro 5 license shown at the alleg.sourceforge.net URL is the same as zlib",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense KAZLIB = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Kazlib"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://git.savannah.gnu.org/cgit/kazlib.git/tree/except.c?id=0062df360c2d17d57f6af19b0e444c51feb99036")
        ],
        LicenseText = ReadResource("Kazlib.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Kazlib.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense ZEND_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Zend-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://web.archive.org/web/20130517195954/http://www.zend.com/license/2_00.txt")
        ],
        LicenseText = ReadResource("Zend-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Zend-2.0.template.txt"),
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense JOVE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/jove"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/jonmacs/jove/blob/4_17/LICENSE")
        ],
        LicenseText = ReadResource("jove.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("jove.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CHECK_CVS = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/check-cvs"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://cvs.savannah.gnu.org/viewvc/cvs/ccvs/contrib/check_cvs.in?revision=1.1.4.3&view=markup&pathrev=cvs1-11-23#l2")
        ],
        LicenseText = ReadResource("check-cvs.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("check-cvs.template.txt"),
        Comment = "This license is similar to FSFULLR.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense DSDP = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/DSDP"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/DSDP")
        ],
        LicenseText = ReadResource("DSDP.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("DSDP.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GFDL_1_1_INVARIANTS_OR_LATER = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GFDL-1.1-invariants-or-later"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/old-licenses/fdl-1.1.txt")
        ],
        LicenseText = ReadResource("GFDL-1.1-invariants-or-later.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GFDL-1.1-invariants-or-later.template.txt"),
        StandardLicenseHeader = ReadResource("GFDL-1.1-invariants-or-later.header.txt"),
        Comment = "This license was released March 2000. The identifier GFDL-1.1-or-later-invariants should only be used when there are Invariant Sections, Front-Cover Texts or Back-Cover Texts. See GFDL-1.1-or-later and GFDL-1.1-or-later-no-invariants for alternatives.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense RSCPL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/RSCPL"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://wayback.archive.org/web/20060715140826/http://www.risource.org/RPL/RPL-1.0A.shtml"),
            new Uri("https://opensource.org/licenses/RSCPL")
        ],
        LicenseText = ReadResource("RSCPL.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("RSCPL.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense PPL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/PPL"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://wiki.p2pfoundation.net/Peer_Production_License"),
            new Uri("http://www.networkcultures.org/_uploads/%233notebook_telekommunist.pdf")
        ],
        LicenseText = ReadResource("PPL.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("PPL.template.txt"),
        Comment = "This license is a modified version of CC-BY-NC-SA-3.0, with the most notable differences being the additions of sections 4(c) and 4(d).",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SWRULE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/swrule"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://ctan.math.utah.edu/ctan/tex-archive/macros/generic/misc/swrule.sty")
        ],
        LicenseText = ReadResource("swrule.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("swrule.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SSLEAY_STANDALONE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/SSLeay-standalone"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.tq-group.com/filedownloads/files/software-license-conditions/OriginalSSLeay/OriginalSSLeay.pdf")
        ],
        LicenseText = ReadResource("SSLeay-standalone.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("SSLeay-standalone.template.txt"),
        Comment = "This is the second license in the OpenSSL two-license stack as a standalone option.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OSL_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OSL-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://web.archive.org/web/20041020171434/http://www.rosenlaw.com/osl2.0.html")
        ],
        LicenseText = ReadResource("OSL-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OSL-2.0.template.txt"),
        StandardLicenseHeader = ReadResource("OSL-2.0.header.txt"),
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense UBUNTU_FONT_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Ubuntu-font-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://ubuntu.com/legal/font-licence"),
            new Uri("https://assets.ubuntu.com/v1/81e5605d-ubuntu-font-licence-1.0.txt")
        ],
        LicenseText = ReadResource("Ubuntu-font-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Ubuntu-font-1.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GFDL_1_1_ONLY = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GFDL-1.1-only"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/old-licenses/fdl-1.1.txt")
        ],
        LicenseText = ReadResource("GFDL-1.1-only.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GFDL-1.1-only.template.txt"),
        StandardLicenseHeader = ReadResource("GFDL-1.1-only.header.txt"),
        Comment = "This license was released March 2000. The identifier GFDL-1.1-only can be used to indicate that this license applies, without asserting whether or not any Invariant Sections, Front-Cover Texts or Back-Cover Texts are present. See GFDL-1.1-only-invariants and GFDL-1.1-only-no-invariants for alternative identifiers that can be used to express explicitly that these sections or cover texts are present or are not present, respectively.",
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SPL_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/SPL-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/SPL-1.0")
        ],
        LicenseText = ReadResource("SPL-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("SPL-1.0.template.txt"),
        StandardLicenseHeader = ReadResource("SPL-1.0.header.txt"),
        Comment = "This license is essentially a rebranded version of MPL-1.1, but with some important changes. In §1.3 it expands the definition of \"Covered Code\" to also include documentation.",
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense MS_LPL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/MS-LPL"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.openhub.net/licenses/mslpl"),
            new Uri("https://github.com/gabegundy/atlserver/blob/master/License.txt"),
            new Uri("https://en.wikipedia.org/wiki/Shared_Source_Initiative#Microsoft_Limited_Public_License_(Ms-LPL)")
        ],
        LicenseText = ReadResource("MS-LPL.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("MS-LPL.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense RUBY = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Ruby"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.ruby-lang.org/en/about/license.txt")
        ],
        LicenseText = ReadResource("Ruby.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Ruby.template.txt"),
        Comment = "Ruby is disjunctively licensed project that allows the choice of this license and another. The other license choice has changed over time (from GPL originally, to BSD-2-Clause currently), so one needs to be aware of that change. The Ruby License itself is un-versioned, but has varied a bit over the years, the last substantive variation being in 2002.",
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GFDL_1_3 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GFDL-1.3"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/fdl-1.3.txt")
        ],
        LicenseText = ReadResource("GFDL-1.3.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GFDL-1.3.template.txt"),
        StandardLicenseHeader = ReadResource("GFDL-1.3.header.txt"),
        IsFsfLibre = true,
        IsOsiApproved = false,
        IsDeprecatedLicenseId = true,
        DeprecatedVersion = "3.0",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense VSL_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/VSL-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/VSL-1.0")
        ],
        LicenseText = ReadResource("VSL-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("VSL-1.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense UNICODE_DFS_2015 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Unicode-DFS-2015"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://web.archive.org/web/20151224134844/http://unicode.org/copyright.html")
        ],
        LicenseText = ReadResource("Unicode-DFS-2015.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Unicode-DFS-2015.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense ANTLR_PD_FALLBACK = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/ANTLR-PD-fallback"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.antlr2.org/license.html")
        ],
        LicenseText = ReadResource("ANTLR-PD-fallback.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("ANTLR-PD-fallback.template.txt"),
        Comment = "ANTLR used a public domain notice through version 2.7 and then switched to a BSD license for version 3.0 and later. Their original notice did not include the third paragraph with the fallback license listed here; see ANTLR-PD for the version without this third paragraph.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OLDAP_1_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OLDAP-1.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.openldap.org/devel/gitweb.cgi?p=openldap.git;a=blob;f=LICENSE;hb=806557a5ad59804ef3a44d5abfbe91d706b0791f")
        ],
        LicenseText = ReadResource("OLDAP-1.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OLDAP-1.1.template.txt"),
        Comment = "This license was released 25 August 1998.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense X11 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/X11"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.xfree86.org/3.3.6/COPYRIGHT2.html#3")
        ],
        LicenseText = ReadResource("X11.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("X11.template.txt"),
        Comment = "This is same as MIT, but with no advertising clause added.",
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BLESSING = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/blessing"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.sqlite.org/src/artifact/e33a4df7e32d742a?ln=4-9"),
            new Uri("https://sqlite.org/src/artifact/df5091916dbb40e6")
        ],
        LicenseText = ReadResource("blessing.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("blessing.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BSD_4_3TAHOE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/BSD-4.3TAHOE"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/389ds/389-ds-base/blob/main/ldap/include/sysexits-compat.h#L15"),
            new Uri("https://git.savannah.gnu.org/cgit/indent.git/tree/doc/indent.texi?id=a74c6b4ee49397cf330b333da1042bffa60ed14f#n1788")
        ],
        LicenseText = ReadResource("BSD-4.3TAHOE.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("BSD-4.3TAHOE.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CLIPS = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Clips"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/DrItanium/maya/blob/master/LICENSE.CLIPS")
        ],
        LicenseText = ReadResource("Clips.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Clips.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BAHYPH = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Bahyph"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/Bahyph")
        ],
        LicenseText = ReadResource("Bahyph.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Bahyph.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense EFL_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/EFL-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.eiffel-nice.org/license/eiffel-forum-license-2.html"),
            new Uri("https://opensource.org/licenses/EFL-2.0")
        ],
        LicenseText = ReadResource("EFL-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("EFL-2.0.template.txt"),
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BSD_4_CLAUSE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/BSD-4-Clause"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://directory.fsf.org/wiki/License:BSD_4Clause")
        ],
        LicenseText = ReadResource("BSD-4-Clause.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("BSD-4-Clause.template.txt"),
        Comment = "This license was rescinded by the author on 22 July 1999.",
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense RPSL_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/RPSL-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://helixcommunity.org/content/rpsl"),
            new Uri("https://opensource.org/licenses/RPSL-1.0")
        ],
        LicenseText = ReadResource("RPSL-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("RPSL-1.0.template.txt"),
        StandardLicenseHeader = ReadResource("RPSL-1.0.header.txt"),
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense EUROSYM = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Eurosym"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/Eurosym")
        ],
        LicenseText = ReadResource("Eurosym.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Eurosym.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GPL_1_0_ = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GPL-1.0+"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/old-licenses/gpl-1.0-standalone.html")
        ],
        LicenseText = ReadResource("GPL-1.0+.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GPL-1.0+.template.txt"),
        StandardLicenseHeader = ReadResource("GPL-1.0+.header.txt"),
        IsDeprecatedLicenseId = true,
        DeprecatedVersion = "2.0rc2",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CONDOR_1_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Condor-1.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://research.cs.wisc.edu/condor/license.html#condor"),
            new Uri("http://web.archive.org/web/20111123062036/http://research.cs.wisc.edu/condor/license.html#condor")
        ],
        LicenseText = ReadResource("Condor-1.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Condor-1.1.template.txt"),
        Comment = "This license was released 30 October 2003",
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense UNICODE_DFS_2016 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Unicode-DFS-2016"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.unicode.org/license.txt"),
            new Uri("http://web.archive.org/web/20160823201924/http://www.unicode.org/copyright.html#License"),
            new Uri("http://www.unicode.org/copyright.html")
        ],
        LicenseText = ReadResource("Unicode-DFS-2016.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Unicode-DFS-2016.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_2_5_AU = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-2.5-AU"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by/2.5/au/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-2.5-AU.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-2.5-AU.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CECILL_B = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CECILL-B"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.cecill.info/licences/Licence_CeCILL-B_V1-en.html")
        ],
        LicenseText = ReadResource("CECILL-B.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CECILL-B.template.txt"),
        Comment = "French version can be found here: http://www.cecill.info/licences/Licence_CeCILL-B_V1-fr.html",
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense MPL_2_0_NO_COPYLEFT_EXCEPTION = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/MPL-2.0-no-copyleft-exception"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.mozilla.org/MPL/2.0/"),
            new Uri("https://opensource.org/licenses/MPL-2.0")
        ],
        LicenseText = ReadResource("MPL-2.0-no-copyleft-exception.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("MPL-2.0-no-copyleft-exception.template.txt"),
        StandardLicenseHeader = ReadResource("MPL-2.0-no-copyleft-exception.header.txt"),
        Comment = "This license was released in January 2012. This license list entry is for use when the MPL's Exhibit B is used, which effectively negates the copyleft compatibility clause in section 3.3.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SGI_OPENGL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/SGI-OpenGL"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://gitlab.freedesktop.org/mesa/glw/-/blob/master/README?ref_type=heads")
        ],
        LicenseText = ReadResource("SGI-OpenGL.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("SGI-OpenGL.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense FSFUL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/FSFUL"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/FSF_Unlimited_License")
        ],
        LicenseText = ReadResource("FSFUL.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("FSFUL.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense ADOBE_UTOPIA = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Adobe-Utopia"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://gitlab.freedesktop.org/xorg/font/adobe-utopia-100dpi/-/blob/master/COPYING?ref_type=heads")
        ],
        LicenseText = ReadResource("Adobe-Utopia.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Adobe-Utopia.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CERN_OHL_P_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CERN-OHL-P-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.ohwr.org/project/cernohl/wikis/Documents/CERN-OHL-version-2")
        ],
        LicenseText = ReadResource("CERN-OHL-P-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CERN-OHL-P-2.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense FSL_1_1_ALV2 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/FSL-1.1-ALv2"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fsl.software/FSL-1.1-ALv2.template.md")
        ],
        LicenseText = ReadResource("FSL-1.1-ALv2.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("FSL-1.1-ALv2.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_3_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-3.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by/3.0/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-3.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-3.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense MUP = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Mup"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/Mup")
        ],
        LicenseText = ReadResource("Mup.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Mup.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CECILL_1_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CECILL-1.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.cecill.info/licences/Licence_CeCILL_V1.1-US.html")
        ],
        LicenseText = ReadResource("CECILL-1.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CECILL-1.1.template.txt"),
        Comment = "There is only an English version for 1.1, which includes some wording changes from v1.0",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense FDK_AAC = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/FDK-AAC"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/FDK-AAC"),
            new Uri("https://directory.fsf.org/wiki/License:Fdk")
        ],
        LicenseText = ReadResource("FDK-AAC.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("FDK-AAC.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_3_0_IGO = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-3.0-IGO"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by/3.0/igo/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-3.0-IGO.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-3.0-IGO.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense PARITY_7_0_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Parity-7.0.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://paritylicense.com/versions/7.0.0.html")
        ],
        LicenseText = ReadResource("Parity-7.0.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Parity-7.0.0.template.txt"),
        Comment = "This license was released on November 3, 2019.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense MPEG_SSG = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/MPEG-SSG"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://sourceforge.net/p/netpbm/code/HEAD/tree/super_stable/converter/ppm/ppmtompeg/jrevdct.c#l1189")
        ],
        LicenseText = ReadResource("MPEG-SSG.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("MPEG-SSG.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense AFL_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/AFL-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://wayback.archive.org/web/20060924134533/http://www.opensource.org/licenses/afl-2.0.txt")
        ],
        LicenseText = ReadResource("AFL-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("AFL-2.0.template.txt"),
        StandardLicenseHeader = ReadResource("AFL-2.0.header.txt"),
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_SA_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-SA-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by-sa/2.0/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-SA-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-SA-2.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OPENSSL_STANDALONE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OpenSSL-standalone"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://library.netapp.com/ecm/ecm_download_file/ECMP1196395"),
            new Uri("https://hstechdocs.helpsystems.com/manuals/globalscape/archive/cuteftp6/open_ssl_license_agreement.htm")
        ],
        LicenseText = ReadResource("OpenSSL-standalone.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OpenSSL-standalone.template.txt"),
        Comment = "This is the first license in the OpenSSL two-license stack as a standalone option.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense HPND_UC_EXPORT_US = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/HPND-UC-export-US"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/RTimothyEdwards/magic/blob/master/LICENSE")
        ],
        LicenseText = ReadResource("HPND-UC-export-US.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("HPND-UC-export-US.template.txt"),
        Comment = "This license is similar to HPND-UC, but adds the sentence related to export law at the end.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SHL_0_5 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/SHL-0.5"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://solderpad.org/licenses/SHL-0.5/")
        ],
        LicenseText = ReadResource("SHL-0.5.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("SHL-0.5.template.txt"),
        StandardLicenseHeader = ReadResource("SHL-0.5.header.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CMU_MACH = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CMU-Mach"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.cs.cmu.edu/~410/licenses.html")
        ],
        LicenseText = ReadResource("CMU-Mach.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CMU-Mach.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by/1.0/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-1.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense AFMPARSE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Afmparse"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/Afmparse")
        ],
        LicenseText = ReadResource("Afmparse.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Afmparse.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SIMPL_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/SimPL-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/SimPL-2.0")
        ],
        LicenseText = ReadResource("SimPL-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("SimPL-2.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GPL_3_0_WITH_GCC_EXCEPTION = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GPL-3.0-with-GCC-exception"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/gcc-exception-3.1.html")
        ],
        LicenseText = ReadResource("GPL-3.0-with-GCC-exception.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GPL-3.0-with-GCC-exception.template.txt"),
        Comment = "DEPRECATED: Use license expression including main license, \"WITH\" operator, and identifier: GCC-exception-3.1",
        IsDeprecatedLicenseId = true,
        DeprecatedVersion = "2.0rc2",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_PDDC = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-PDDC"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/publicdomain/")
        ],
        LicenseText = ReadResource("CC-PDDC.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-PDDC.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense TOSL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/TOSL"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/TOSL")
        ],
        LicenseText = ReadResource("TOSL.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("TOSL.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense IBM_PIBS = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/IBM-pibs"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://git.denx.de/?p=u-boot.git;a=blob;f=arch/powerpc/cpu/ppc4xx/miiphy.c;h=297155fdafa064b955e53e9832de93bfb0cfb85b;hb=9fab4bf4cc077c21e43941866f3f2c196f28670d")
        ],
        LicenseText = ReadResource("IBM-pibs.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("IBM-pibs.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense AFL_2_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/AFL-2.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://opensource.linux-mirror.org/licenses/afl-2.1.txt")
        ],
        LicenseText = ReadResource("AFL-2.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("AFL-2.1.template.txt"),
        StandardLicenseHeader = ReadResource("AFL-2.1.header.txt"),
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense ECL_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/ECL-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/ECL-1.0")
        ],
        LicenseText = ReadResource("ECL-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("ECL-1.0.template.txt"),
        StandardLicenseHeader = ReadResource("ECL-1.0.header.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GFDL_1_2_NO_INVARIANTS_ONLY = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GFDL-1.2-no-invariants-only"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/old-licenses/fdl-1.2.txt")
        ],
        LicenseText = ReadResource("GFDL-1.2-no-invariants-only.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GFDL-1.2-no-invariants-only.template.txt"),
        StandardLicenseHeader = ReadResource("GFDL-1.2-no-invariants-only.header.txt"),
        Comment = "This license was released November 2002. The identifier GFDL-1.2-only-no-invariants should only be used when there are no Invariant Sections, Front-Cover Texts or Back-Cover Texts. See GFDL-1.2-only and GFDL-1.2-only-invariants for alternatives.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_NC_SA_3_0_DE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-NC-SA-3.0-DE"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by-nc-sa/3.0/de/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-NC-SA-3.0-DE.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-NC-SA-3.0-DE.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SPENCER_94 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Spencer-94"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/Henry_Spencer_Reg-Ex_Library_License"),
            new Uri("https://metacpan.org/release/KNOK/File-MMagic-1.30/source/COPYING#L28")
        ],
        LicenseText = ReadResource("Spencer-94.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Spencer-94.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LAL_1_2 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/LAL-1.2"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://artlibre.org/licence/lal/licence-art-libre-12/")
        ],
        LicenseText = ReadResource("LAL-1.2.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("LAL-1.2.template.txt"),
        Comment = "French is the canonical language for this license. Translations are available in: English: http://artlibre.org/licence/lal/licence-art-libre-12/ Italian: http://artlibre.org/licence/lal/it/ Spanish: http://artlibre.org/licence/lal/es/",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GPL_3_0_ONLY = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GPL-3.0-only"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/gpl-3.0-standalone.html"),
            new Uri("https://opensource.org/licenses/GPL-3.0")
        ],
        LicenseText = ReadResource("GPL-3.0-only.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GPL-3.0-only.template.txt"),
        StandardLicenseHeader = ReadResource("GPL-3.0-only.header.txt"),
        Comment = "This license was released: 29 June 2007. This license identifier refers to the choice to use the code under GPL-3.0-only, as distinguished from the use of code under GPL-3.0-or-later (i.e., GPL-3.0 or some later version). The license notice (as seen in the Standard License Header field below) states which of these applies to the code in the file. The example in the How to Apply These Terms appendix of the license shows the \"or later\" approach.",
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BSD_SYSTEMICS = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/BSD-Systemics"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://metacpan.org/release/DPARIS/Crypt-DES-2.07/source/COPYRIGHT")
        ],
        LicenseText = ReadResource("BSD-Systemics.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("BSD-Systemics.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense HPND_SELL_MIT_DISCLAIMER_XSERVER = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/HPND-sell-MIT-disclaimer-xserver"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://gitlab.freedesktop.org/xorg/xserver/-/blob/master/COPYING?ref_type=heads#L1781")
        ],
        LicenseText = ReadResource("HPND-sell-MIT-disclaimer-xserver.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("HPND-sell-MIT-disclaimer-xserver.template.txt"),
        Comment = "This is similar to HPND-sell-variant-MIT-disclaimer but it omits the copyright notice reproduction obligation.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense NEWSLETR = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Newsletr"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/Newsletr")
        ],
        LicenseText = ReadResource("Newsletr.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Newsletr.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CECILL_C = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CECILL-C"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.cecill.info/licences/Licence_CeCILL-C_V1-en.html")
        ],
        LicenseText = ReadResource("CECILL-C.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CECILL-C.template.txt"),
        Comment = "French version can be found here: http://www.cecill.info/licences/Licence_CeCILL-C_V1-fr.html",
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense ANY_OSI = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/any-OSI"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://metacpan.org/pod/Exporter::Tidy#LICENSE")
        ],
        LicenseText = ReadResource("any-OSI.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("any-OSI.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense PDDL_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/PDDL-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://opendatacommons.org/licenses/pddl/1.0/"),
            new Uri("https://opendatacommons.org/licenses/pddl/")
        ],
        LicenseText = ReadResource("PDDL-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("PDDL-1.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GFDL_1_3_ONLY = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GFDL-1.3-only"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/fdl-1.3.txt")
        ],
        LicenseText = ReadResource("GFDL-1.3-only.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GFDL-1.3-only.template.txt"),
        StandardLicenseHeader = ReadResource("GFDL-1.3-only.header.txt"),
        Comment = "This license was released 3 November 2008. The identifier GFDL-1.3-only can be used to indicate that this license applies, without asserting whether or not any Invariant Sections, Front-Cover Texts or Back-Cover Texts are present. See GFDL-1.3-only-invariants and GFDL-1.3-only-no-invariants for alternative identifiers that can be used to express explicitly that these sections or cover texts are present or are not present, respectively.",
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense NOWEB = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Noweb"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/Noweb")
        ],
        LicenseText = ReadResource("Noweb.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Noweb.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense EUPL_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/EUPL-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://ec.europa.eu/idabc/en/document/7330.html"),
            new Uri("http://ec.europa.eu/idabc/servlets/Doc027f.pdf?id=31096")
        ],
        LicenseText = ReadResource("EUPL-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("EUPL-1.0.template.txt"),
        Comment = "The European Commission has approved the EUPL on 9 January 2007.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SSH_KEYSCAN = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/ssh-keyscan"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/openssh/openssh-portable/blob/master/LICENCE#L82")
        ],
        LicenseText = ReadResource("ssh-keyscan.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("ssh-keyscan.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CDLA_PERMISSIVE_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CDLA-Permissive-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://cdla.dev/permissive-2-0")
        ],
        LicenseText = ReadResource("CDLA-Permissive-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CDLA-Permissive-2.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense FAIR = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Fair"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://web.archive.org/web/20150926120323/http://fairlicense.org/"),
            new Uri("https://opensource.org/licenses/Fair")
        ],
        LicenseText = ReadResource("Fair.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Fair.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense ZLIB = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Zlib"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.zlib.net/zlib_license.html"),
            new Uri("https://opensource.org/licenses/Zlib")
        ],
        LicenseText = ReadResource("Zlib.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Zlib.template.txt"),
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_NC_ND_3_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-NC-ND-3.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by-nc-nd/3.0/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-NC-ND-3.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-NC-ND-3.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense DOCBOOK_DTD = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/DocBook-DTD"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.docbook.org/xml/simple/1.1/docbook-simple-1.1.zip")
        ],
        LicenseText = ReadResource("DocBook-DTD.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("DocBook-DTD.template.txt"),
        Comment = "This license is very similar to DocBook-Schema, but includes some exceptions to the different labeling of a modified version.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_NC_SA_2_5 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-NC-SA-2.5"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by-nc-sa/2.5/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-NC-SA-2.5.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-NC-SA-2.5.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense JSON = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/JSON"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.json.org/license.html")
        ],
        LicenseText = ReadResource("JSON.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("JSON.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense PYTHON_2_0_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Python-2.0.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.python.org/download/releases/2.0.1/license/"),
            new Uri("https://docs.python.org/3/license.html"),
            new Uri("https://github.com/python/cpython/blob/main/LICENSE")
        ],
        LicenseText = ReadResource("Python-2.0.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Python-2.0.1.template.txt"),
        Comment = "For Python release 1.6.1, apparently the CNRI-Python license part of the stack was replaced with CNRI-Python-GPL-Compatible",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense AML_GLSLANG = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/AML-glslang"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/KhronosGroup/glslang/blob/main/LICENSE.txt#L949"),
            new Uri("https://docs.omniverse.nvidia.com/install-guide/latest/common/licenses.html")
        ],
        LicenseText = ReadResource("AML-glslang.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("AML-glslang.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BSD_INFERNO_NETTVERK = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/BSD-Inferno-Nettverk"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.inet.no/dante/LICENSE")
        ],
        LicenseText = ReadResource("BSD-Inferno-Nettverk.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("BSD-Inferno-Nettverk.template.txt"),
        Comment = "This license is similar to BSD-4-Clause but it combines first two clauses and includes a request that improvements or extensions be sent to the author.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BRIAN_GLADMAN_3_CLAUSE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Brian-Gladman-3-Clause"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/SWI-Prolog/packages-clib/blob/master/sha1/brg_endian.h")
        ],
        LicenseText = ReadResource("Brian-Gladman-3-Clause.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Brian-Gladman-3-Clause.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense WWL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/wwl"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.db.net/downloads/wwl+db-1.3.tgz")
        ],
        LicenseText = ReadResource("wwl.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("wwl.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CDDL_1_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CDDL-1.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://glassfish.java.net/public/CDDL+GPL_1_1.html"),
            new Uri("https://javaee.github.io/glassfish/LICENSE")
        ],
        LicenseText = ReadResource("CDDL-1.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CDDL-1.1.template.txt"),
        Comment = "Same as 1.0, but changes name from Sun to Oracle in section 4.1 and adds patent infringement termination clause (section 6.3)",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense TERMREADKEY = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/TermReadKey"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/jonathanstowe/TermReadKey/blob/master/README#L9-L10")
        ],
        LicenseText = ReadResource("TermReadKey.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("TermReadKey.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OLDAP_2_2_2 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OLDAP-2.2.2"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.openldap.org/devel/gitweb.cgi?p=openldap.git;a=blob;f=LICENSE;hb=df2cc1e21eb7c160695f5b7cffd6296c151ba188")
        ],
        LicenseText = ReadResource("OLDAP-2.2.2.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OLDAP-2.2.2.template.txt"),
        Comment = "This license was released 28 July 2000.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense RSA_MD = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/RSA-MD"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.faqs.org/rfcs/rfc1321.html")
        ],
        LicenseText = ReadResource("RSA-MD.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("RSA-MD.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BSD_2_CLAUSE_FIRST_LINES = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/BSD-2-Clause-first-lines"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/krb5/krb5/blob/krb5-1.21.2-final/NOTICE#L664-L690"),
            new Uri("https://web.mit.edu/kerberos/krb5-1.21/doc/mitK5license.html")
        ],
        LicenseText = ReadResource("BSD-2-Clause-first-lines.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("BSD-2-Clause-first-lines.template.txt"),
        Comment = "This is the same as BSD-2-Clause, but adds a specific requirement to retain the notice in the first lines of the file.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LGPL_3_0_OR_LATER = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/LGPL-3.0-or-later"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/lgpl-3.0-standalone.html"),
            new Uri("https://www.gnu.org/licenses/lgpl+gpl-3.0.txt"),
            new Uri("https://opensource.org/licenses/LGPL-3.0")
        ],
        LicenseText = ReadResource("LGPL-3.0-or-later.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("LGPL-3.0-or-later.template.txt"),
        Comment = "This license was released: 29 June 2007. This refers to when this version of the LGPL, or any later version, is used (as opposed to \"only\" this version). The markup includes the GPL-3.0 text as optional text, because the LGPL-3.0 is structured as a supplement to the terms of GPL-3.0.",
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense NGPL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/NGPL"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/NGPL")
        ],
        LicenseText = ReadResource("NGPL.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("NGPL.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense EGENIX = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/eGenix"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.egenix.com/products/eGenix.com-Public-License-1.1.0.pdf"),
            new Uri("https://fedoraproject.org/wiki/Licensing/eGenix.com_Public_License_1.1.0")
        ],
        LicenseText = ReadResource("eGenix.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("eGenix.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SLEEPYCAT = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Sleepycat"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/Sleepycat")
        ],
        LicenseText = ReadResource("Sleepycat.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Sleepycat.template.txt"),
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense ADOBE_GLYPH = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Adobe-Glyph"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/MIT#AdobeGlyph")
        ],
        LicenseText = ReadResource("Adobe-Glyph.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Adobe-Glyph.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense MS_PL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/MS-PL"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.microsoft.com/opensource/licenses.mspx"),
            new Uri("https://opensource.org/licenses/MS-PL")
        ],
        LicenseText = ReadResource("MS-PL.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("MS-PL.template.txt"),
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LPPL_1_3C = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/LPPL-1.3c"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.latex-project.org/lppl/lppl-1-3c.txt"),
            new Uri("https://opensource.org/licenses/LPPL-1.3c")
        ],
        LicenseText = ReadResource("LPPL-1.3c.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("LPPL-1.3c.template.txt"),
        StandardLicenseHeader = ReadResource("LPPL-1.3c.header.txt"),
        Comment = "This license was released: 4 May 2008",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OLDAP_2_4 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OLDAP-2.4"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.openldap.org/devel/gitweb.cgi?p=openldap.git;a=blob;f=LICENSE;hb=cd1284c4a91a8a380d904eee68d1583f989ed386")
        ],
        LicenseText = ReadResource("OLDAP-2.4.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OLDAP-2.4.template.txt"),
        Comment = "This license was released 8 December 2000.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BSD_2_CLAUSE_PKGCONF_DISCLAIMER = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/BSD-2-Clause-pkgconf-disclaimer"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/audacious-media-player/audacious/blob/master/src/audacious/main.cc"),
            new Uri("https://github.com/audacious-media-player/audacious/blob/master/COPYING")
        ],
        LicenseText = ReadResource("BSD-2-Clause-pkgconf-disclaimer.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("BSD-2-Clause-pkgconf-disclaimer.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense IMAGEMAGICK = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/ImageMagick"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.imagemagick.org/script/license.php")
        ],
        LicenseText = ReadResource("ImageMagick.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("ImageMagick.template.txt"),
        Comment = "The ImageMagick license is nearly identical to the Apache-2.0 license. The differences are the title and additional preamble, and the omission of the parenthetical \"(except as stated in this section)\" from Section 3.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OLDAP_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OLDAP-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.openldap.org/devel/gitweb.cgi?p=openldap.git;a=blob;f=LICENSE;hb=cbf50f4e1185a21abd4c0a54d3f4341fe28f36ea")
        ],
        LicenseText = ReadResource("OLDAP-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OLDAP-2.0.template.txt"),
        Comment = "This license was released 7 June 1999.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BSD_2_CLAUSE_NETBSD = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/BSD-2-Clause-NetBSD"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.netbsd.org/about/redistribution.html#default")
        ],
        LicenseText = ReadResource("BSD-2-Clause-NetBSD.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("BSD-2-Clause-NetBSD.template.txt"),
        Comment = "NetBSD adopted this 2-clause license in 2008 for code contributed to NetBSD Foundation. It is being deprecated as a separate license because it is a match to BSD-2-Clause. The line describing that the code is derived from software contributed to NetBSD is not viewed as being a substantive part of the license text.",
        IsFsfLibre = true,
        IsOsiApproved = false,
        IsDeprecatedLicenseId = true,
        DeprecatedVersion = "3.9",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense XINETD = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/xinetd"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/Xinetd_License")
        ],
        LicenseText = ReadResource("xinetd.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("xinetd.template.txt"),
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense DVIPDFM = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/dvipdfm"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/dvipdfm")
        ],
        LicenseText = ReadResource("dvipdfm.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("dvipdfm.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense C_UDA_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/C-UDA-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/microsoft/Computational-Use-of-Data-Agreement/blob/master/C-UDA-1.0.md"),
            new Uri("https://cdla.dev/computational-use-of-data-agreement-v1-0/")
        ],
        LicenseText = ReadResource("C-UDA-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("C-UDA-1.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OML = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OML"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/Open_Market_License")
        ],
        LicenseText = ReadResource("OML.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OML.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OFFIS = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OFFIS"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://sourceforge.net/p/xmedcon/code/ci/master/tree/libs/dicom/README")
        ],
        LicenseText = ReadResource("OFFIS.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OFFIS.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense TCL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/TCL"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.tcl.tk/software/tcltk/license.html"),
            new Uri("https://fedoraproject.org/wiki/Licensing/TCL")
        ],
        LicenseText = ReadResource("TCL.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("TCL.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense HPND_KEVLIN_HENNEY = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/HPND-Kevlin-Henney"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/mruby/mruby/blob/83d12f8d52522cdb7c8cc46fad34821359f453e6/mrbgems/mruby-dir/src/Win/dirent.c#L127-L140")
        ],
        LicenseText = ReadResource("HPND-Kevlin-Henney.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("HPND-Kevlin-Henney.template.txt"),
        Comment = "This license is similar to HPND-Pbmplus but varies the order of hereby granted/without fee and has a different notice clause.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense MAKEINDEX = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/MakeIndex"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/MakeIndex")
        ],
        LicenseText = ReadResource("MakeIndex.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("MakeIndex.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense MTLL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/MTLL"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/Matrix_Template_Library_License")
        ],
        LicenseText = ReadResource("MTLL.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("MTLL.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense DEC_3_CLAUSE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/DEC-3-Clause"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://gitlab.freedesktop.org/xorg/xserver/-/blob/master/COPYING?ref_type=heads#L239")
        ],
        LicenseText = ReadResource("DEC-3-Clause.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("DEC-3-Clause.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BITSTREAM_VERA = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Bitstream-Vera"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://web.archive.org/web/20080207013128/http://www.gnome.org/fonts/"),
            new Uri("https://docubrain.com/sites/default/files/licenses/bitstream-vera.html")
        ],
        LicenseText = ReadResource("Bitstream-Vera.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Bitstream-Vera.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GPL_1_0_ONLY = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GPL-1.0-only"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/old-licenses/gpl-1.0-standalone.html")
        ],
        LicenseText = ReadResource("GPL-1.0-only.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GPL-1.0-only.template.txt"),
        StandardLicenseHeader = ReadResource("GPL-1.0-only.header.txt"),
        Comment = "This license was released: February 1989. This license identifier refers to the choice to use the code under GPL-1.0-only, as distinguished from the use of code under GPL-1.0-or-later (i.e., GPL-1.0 or some later version). The license notice (as seen in the Standard License Header field below) states which of these applies to the code in the file. The example in the How to Apply These Terms appendix of the license shows the \"or later\" approach.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense COIL_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/COIL-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://coil.apotheon.org/plaintext/01.0.txt")
        ],
        LicenseText = ReadResource("COIL-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("COIL-1.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense ALADDIN = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Aladdin"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://pages.cs.wisc.edu/~ghost/doc/AFPL/6.01/Public.htm")
        ],
        LicenseText = ReadResource("Aladdin.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Aladdin.template.txt"),
        Comment = "This license was released 18 Nov 1999",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense XZOOM = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/xzoom"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://metadata.ftp-master.debian.org/changelogs//main/x/xzoom/xzoom_0.3-27_copyright")
        ],
        LicenseText = ReadResource("xzoom.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("xzoom.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense HP_1986 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/HP-1986"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://sourceware.org/git/?p=newlib-cygwin.git;a=blob;f=newlib/libc/machine/hppa/memchr.S;h=1cca3e5e8867aa4bffef1f75a5c1bba25c0c441e;hb=HEAD#l2")
        ],
        LicenseText = ReadResource("HP-1986.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("HP-1986.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LGPL_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/LGPL-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/old-licenses/lgpl-2.0-standalone.html")
        ],
        LicenseText = ReadResource("LGPL-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("LGPL-2.0.template.txt"),
        StandardLicenseHeader = ReadResource("LGPL-2.0.header.txt"),
        IsDeprecatedLicenseId = true,
        DeprecatedVersion = "3.0",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense ETALAB_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/etalab-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/DISIC/politique-de-contribution-open-source/blob/master/LICENSE.pdf"),
            new Uri("https://raw.githubusercontent.com/DISIC/politique-de-contribution-open-source/master/LICENSE")
        ],
        LicenseText = ReadResource("etalab-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("etalab-2.0.template.txt"),
        Comment = "English translation can be found here: https://www.etalab.gouv.fr/wp-content/uploads/2018/11/open-licence.pdf",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense ZEEFF = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Zeeff"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("ftp://ftp.tin.org/pub/news/utils/newsx/newsx-1.6.tar.gz")
        ],
        LicenseText = ReadResource("Zeeff.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Zeeff.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense HPND_DEC = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/HPND-DEC"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://gitlab.freedesktop.org/xorg/app/xkbcomp/-/blob/master/COPYING?ref_type=heads#L69")
        ],
        LicenseText = ReadResource("HPND-DEC.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("HPND-DEC.template.txt"),
        Comment = "The permission grant is the same as HPND, but the disclaimer is quite different and there is a obligation related to modified versions.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_NC_SA_4_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-NC-SA-4.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by-nc-sa/4.0/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-NC-SA-4.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-NC-SA-4.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BSD_4_CLAUSE_UC = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/BSD-4-Clause-UC"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.freebsd.org/copyright/license.html")
        ],
        LicenseText = ReadResource("BSD-4-Clause-UC.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("BSD-4-Clause-UC.template.txt"),
        Comment = "This is the same license as the BSD-4-Clause, but with a copyright notice for the Regents of the University of California. Captures the retroactive deletion of the third (advertising) clause of the Original BSD license for BSD-licensed code developed by UC Berkeley and its contributors (see ftp://ftp.cs.berkeley.edu/pub/4bsd/README.Impt.License.Change)",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GLWTPL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GLWTPL"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/me-shaon/GLWTPL/commit/da5f6bc734095efbacb442c0b31e33a65b9d6e85")
        ],
        LicenseText = ReadResource("GLWTPL.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GLWTPL.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense FREEIMAGE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/FreeImage"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://freeimage.sourceforge.net/freeimage-license.txt")
        ],
        LicenseText = ReadResource("FreeImage.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("FreeImage.template.txt"),
        Comment = "This is similar to MPL-1.0, but for the names, choice of law, and jurisdiction",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense MIT = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/MIT"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/license/mit/"),
            new Uri("http://opensource.org/licenses/MIT")
        ],
        LicenseText = ReadResource("MIT.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("MIT.template.txt"),
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense ZPL_2_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/ZPL-2.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://old.zope.org/Resources/ZPL/")
        ],
        LicenseText = ReadResource("ZPL-2.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("ZPL-2.1.template.txt"),
        Comment = "This is a generic version of the ZPL 2.0 license",
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense WATCOM_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Watcom-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/Watcom-1.0")
        ],
        LicenseText = ReadResource("Watcom-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Watcom-1.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LGPL_2_1_OR_LATER = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/LGPL-2.1-or-later"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/old-licenses/lgpl-2.1-standalone.html"),
            new Uri("https://opensource.org/licenses/LGPL-2.1")
        ],
        LicenseText = ReadResource("LGPL-2.1-or-later.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("LGPL-2.1-or-later.template.txt"),
        StandardLicenseHeader = ReadResource("LGPL-2.1-or-later.header.txt"),
        Comment = "This license was released: February 1999. This license identifier refers to the choice to use code under LGPL-2.1-or-later (i.e., LGPL-2.1 or some later version), as distinguished from use of code under LGPL-2.1-only. The license notice (as seen in the Standard License Header field below) states which of these applies the code in the file. The example in the exhibit to the license shows the license notice for the \"or later\" approach.",
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense INTEL_ACPI = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Intel-ACPI"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/Intel_ACPI_Software_License_Agreement")
        ],
        LicenseText = ReadResource("Intel-ACPI.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Intel-ACPI.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LPPL_1_2 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/LPPL-1.2"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.latex-project.org/lppl/lppl-1-2.txt")
        ],
        LicenseText = ReadResource("LPPL-1.2.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("LPPL-1.2.template.txt"),
        StandardLicenseHeader = ReadResource("LPPL-1.2.header.txt"),
        Comment = "This license was released 3 Sept 1999.",
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_ND_4_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-ND-4.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by-nd/4.0/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-ND-4.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-ND-4.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense RPL_1_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/RPL-1.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/RPL-1.1")
        ],
        LicenseText = ReadResource("RPL-1.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("RPL-1.1.template.txt"),
        Comment = "This license has been superseded by the Reciprocal Public License, version 1.5",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SOFA = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/SOFA"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.iausofa.org/tandc.html")
        ],
        LicenseText = ReadResource("SOFA.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("SOFA.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CORNELL_LOSSLESS_JPEG = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Cornell-Lossless-JPEG"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://android.googlesource.com/platform/external/dng_sdk/+/refs/heads/master/source/dng_lossless_jpeg.cpp#16"),
            new Uri("https://www.mssl.ucl.ac.uk/~mcrw/src/20050920/proto.h"),
            new Uri("https://gitlab.freedesktop.org/libopenraw/libopenraw/blob/master/lib/ljpegdecompressor.cpp#L32")
        ],
        LicenseText = ReadResource("Cornell-Lossless-JPEG.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Cornell-Lossless-JPEG.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense NIST_PD = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/NIST-PD"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/tcheneau/simpleRPL/blob/e645e69e38dd4e3ccfeceb2db8cba05b7c2e0cd3/LICENSE.txt"),
            new Uri("https://github.com/tcheneau/Routing/blob/f09f46fcfe636107f22f2c98348188a65a135d98/README.md")
        ],
        LicenseText = ReadResource("NIST-PD.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("NIST-PD.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OLDAP_2_3 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OLDAP-2.3"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.openldap.org/devel/gitweb.cgi?p=openldap.git;a=blob;f=LICENSE;hb=d32cf54a32d581ab475d23c810b0a7fbaf8d63c3")
        ],
        LicenseText = ReadResource("OLDAP-2.3.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OLDAP-2.3.template.txt"),
        Comment = "This license was released 28 July 2000.",
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GPL_2_0_WITH_AUTOCONF_EXCEPTION = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GPL-2.0-with-autoconf-exception"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://ac-archive.sourceforge.net/doc/copyright.html")
        ],
        LicenseText = ReadResource("GPL-2.0-with-autoconf-exception.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GPL-2.0-with-autoconf-exception.template.txt"),
        Comment = "DEPRECATED: Use license expression including main license, \"WITH\" operator, and identifier: Autoconf-exception-2.0",
        IsDeprecatedLicenseId = true,
        DeprecatedVersion = "2.0rc2",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense ZIMBRA_1_4 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Zimbra-1.4"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.zimbra.com/legal/zimbra-public-license-1-4")
        ],
        LicenseText = ReadResource("Zimbra-1.4.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Zimbra-1.4.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense O_UDA_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/O-UDA-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/microsoft/Open-Use-of-Data-Agreement/blob/v1.0/O-UDA-1.0.md"),
            new Uri("https://cdla.dev/open-use-of-data-agreement-v1-0/")
        ],
        LicenseText = ReadResource("O-UDA-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("O-UDA-1.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_ND_2_5 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-ND-2.5"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by-nd/2.5/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-ND-2.5.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-ND-2.5.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SUGARCRM_1_1_3 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/SugarCRM-1.1.3"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.sugarcrm.com/crm/SPL")
        ],
        LicenseText = ReadResource("SugarCRM-1.1.3.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("SugarCRM-1.1.3.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense NETCDF = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/NetCDF"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.unidata.ucar.edu/software/netcdf/copyright.html")
        ],
        LicenseText = ReadResource("NetCDF.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("NetCDF.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense MIT_KHRONOS_OLD = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/MIT-Khronos-old"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/KhronosGroup/SPIRV-Cross/blob/main/LICENSES/LicenseRef-KhronosFreeUse.txt")
        ],
        LicenseText = ReadResource("MIT-Khronos-old.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("MIT-Khronos-old.template.txt"),
        Comment = "This license is considered obsolete by the Khronos Group, but may still be in use in older projects or versions.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense NLOD_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/NLOD-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://data.norge.no/nlod/en/2.0")
        ],
        LicenseText = ReadResource("NLOD-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("NLOD-2.0.template.txt"),
        Comment = "Norwegian translation available here: http://data.norge.no/nlod/no/2.0",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense MIT_FESTIVAL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/MIT-Festival"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/festvox/flite/blob/master/COPYING"),
            new Uri("https://github.com/festvox/speech_tools/blob/master/COPYING")
        ],
        LicenseText = ReadResource("MIT-Festival.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("MIT-Festival.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SMAIL_GPL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/SMAIL-GPL"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://sources.debian.org/copyright/license/debianutils/4.11.2/")
        ],
        LicenseText = ReadResource("SMAIL-GPL.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("SMAIL-GPL.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense W3M = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/w3m"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/tats/w3m/blob/master/COPYING")
        ],
        LicenseText = ReadResource("w3m.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("w3m.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_NC_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-NC-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by-nc/2.0/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-NC-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-NC-2.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense MIT_CMU = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/MIT-CMU"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing:MIT?rd=Licensing/MIT#CMU_Style"),
            new Uri("https://github.com/python-pillow/Pillow/blob/fffb426092c8db24a5f4b6df243a8a3c01fb63cd/LICENSE")
        ],
        LicenseText = ReadResource("MIT-CMU.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("MIT-CMU.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SMLNJ = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/SMLNJ"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.smlnj.org/license.html")
        ],
        LicenseText = ReadResource("SMLNJ.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("SMLNJ.template.txt"),
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BSL_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/BSL-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.boost.org/LICENSE_1_0.txt"),
            new Uri("https://opensource.org/licenses/BSL-1.0")
        ],
        LicenseText = ReadResource("BSL-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("BSL-1.0.template.txt"),
        Comment = "This license was released: 17 August 2003",
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LINUX_MAN_PAGES_COPYLEFT_2_PARA = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Linux-man-pages-copyleft-2-para"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://git.kernel.org/pub/scm/docs/man-pages/man-pages.git/tree/man2/move_pages.2#n5"),
            new Uri("https://git.kernel.org/pub/scm/docs/man-pages/man-pages.git/tree/man2/migrate_pages.2#n8")
        ],
        LicenseText = ReadResource("Linux-man-pages-copyleft-2-para.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Linux-man-pages-copyleft-2-para.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GPL_2_0_OR_LATER = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GPL-2.0-or-later"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/old-licenses/gpl-2.0-standalone.html"),
            new Uri("https://opensource.org/licenses/GPL-2.0")
        ],
        LicenseText = ReadResource("GPL-2.0-or-later.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GPL-2.0-or-later.template.txt"),
        StandardLicenseHeader = ReadResource("GPL-2.0-or-later.header.txt"),
        Comment = "This license was released: June 1991. This license identifier refers to the choice to use code under GPL-2.0-or-later (i.e., GPL-2.0 or some later version), as distinguished from the use of code under GPL-2.0-only. The license notice (as seen in the Standard License Header field below) states which of these applies to the code in the file. The example in the How to Apply These Terms appendix of the license shows the \"or later\" approach.",
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LGPL_2_1_ = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/LGPL-2.1+"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/old-licenses/lgpl-2.1-standalone.html"),
            new Uri("https://opensource.org/licenses/LGPL-2.1")
        ],
        LicenseText = ReadResource("LGPL-2.1+.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("LGPL-2.1+.template.txt"),
        StandardLicenseHeader = ReadResource("LGPL-2.1+.header.txt"),
        IsFsfLibre = true,
        IsOsiApproved = true,
        IsDeprecatedLicenseId = true,
        DeprecatedVersion = "2.0rc2",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense MULANPSL_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/MulanPSL-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://license.coscl.org.cn/MulanPSL2")
        ],
        LicenseText = ReadResource("MulanPSL-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("MulanPSL-2.0.template.txt"),
        StandardLicenseHeader = ReadResource("MulanPSL-2.0.header.txt"),
        Comment = "Both the Chinese and English translations of this license have been included in the markup, because current examples of use appear to include both translations in license documents.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense JPNIC = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/JPNIC"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://gitlab.isc.org/isc-projects/bind9/blob/master/COPYRIGHT#L366")
        ],
        LicenseText = ReadResource("JPNIC.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("JPNIC.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense AFL_1_2 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/AFL-1.2"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://opensource.linux-mirror.org/licenses/afl-1.2.txt"),
            new Uri("http://wayback.archive.org/web/20021204204652/http://www.opensource.org/licenses/academic.php")
        ],
        LicenseText = ReadResource("AFL-1.2.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("AFL-1.2.template.txt"),
        StandardLicenseHeader = ReadResource("AFL-1.2.header.txt"),
        Comment = "This license has been superseded by later versions. We found these notes here: https://web.archive.org/web/20100828113909/http://opensource.linux-mirror.org/licenses/afl-1.2.txt The following is intended to describe the essential differences between the Academic Free License (AFL) version 1.0 and other open source licenses: The Academic Free License is similar to the BSD, MIT, UoI/NCSA and Apache licenses in many respects but it is intended to solve a few problems with those licenses. * The AFL is written so as to make it clear what software is being licensed (by the inclusion of a statement following the copyright notice in the software). This way, the license functions better than a template license. The BSD, MIT and UoI/NCSA licenses apply to unidentified software. * The AFL contains a complete copyright grant to the software. The BSD and Apache licenses are vague and incomplete in that respect. * The AFL contains a complete patent grant to the software. The BSD, MIT, UoI/NCSA and Apache licenses rely on an implied patent license and contain no explicit patent grant. * The AFL makes it clear that no trademark rights are granted to the licensor's trademarks. The Apache license contains such a provision, but the BSD, MIT and UoI/NCSA licenses do not. * The AFL includes the warranty by the licensor that it either owns the copyright or that it is distributing the software under a license. None of the other licenses contain that warranty. All other warranties are disclaimed, as is the case for the other licenses. * The AFL is itself copyrighted (with the right granted to copy and distribute without modification). This ensures that the owner of the copyright to the license will control changes. The Apache license contains a copyright notice, but the BSD, MIT and UoI/NCSA licenses do not.",
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense MITNFA = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/MITNFA"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/MITNFA")
        ],
        LicenseText = ReadResource("MITNFA.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("MITNFA.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GENERIC_XTS = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/generic-xts"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/mhogomchungu/zuluCrypt/blob/master/external_libraries/tcplay/generic_xts.c")
        ],
        LicenseText = ReadResource("generic-xts.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("generic-xts.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense ZLIB_ACKNOWLEDGEMENT = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/zlib-acknowledgement"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/ZlibWithAcknowledgement")
        ],
        LicenseText = ReadResource("zlib-acknowledgement.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("zlib-acknowledgement.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CMU_MACH_NODOC = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CMU-Mach-nodoc"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/krb5/krb5/blob/krb5-1.21.2-final/NOTICE#L718-L728"),
            new Uri("https://web.mit.edu/kerberos/krb5-1.21/doc/mitK5license.html")
        ],
        LicenseText = ReadResource("CMU-Mach-nodoc.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CMU-Mach-nodoc.template.txt"),
        Comment = "This is similar to CMU-Mach but omits the obligation that both notices appear in supporting documentation and omits the request to return improvements or extensions back to the copyright holder.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SAX_PD_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/SAX-PD-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.saxproject.org/copying.html")
        ],
        LicenseText = ReadResource("SAX-PD-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("SAX-PD-2.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LINUX_MAN_PAGES_COPYLEFT_VAR = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Linux-man-pages-copyleft-var"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://git.kernel.org/pub/scm/docs/man-pages/man-pages.git/tree/man2/set_mempolicy.2#n5")
        ],
        LicenseText = ReadResource("Linux-man-pages-copyleft-var.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Linux-man-pages-copyleft-var.template.txt"),
        Comment = "This is the same as Linux-man-pages-copyleft but omits the last sentence of the third paragraph.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CDLA_PERMISSIVE_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CDLA-Permissive-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://cdla.io/permissive-1-0")
        ],
        LicenseText = ReadResource("CDLA-Permissive-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CDLA-Permissive-1.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense MAILPRIO = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/mailprio"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fossies.org/linux/sendmail/contrib/mailprio")
        ],
        LicenseText = ReadResource("mailprio.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("mailprio.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense DL_DE_ZERO_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/DL-DE-ZERO-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.govdata.de/dl-de/zero-2-0")
        ],
        LicenseText = ReadResource("DL-DE-ZERO-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("DL-DE-ZERO-2.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense EPL_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/EPL-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.eclipse.org/legal/epl-2.0"),
            new Uri("https://www.opensource.org/licenses/EPL-2.0"),
            new Uri("https://www.eclipse.org/legal/epl-v20.html"),
            new Uri("https://projects.eclipse.org/license/epl-2.0")
        ],
        LicenseText = ReadResource("EPL-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("EPL-2.0.template.txt"),
        Comment = "Secondary Licenses declared via Exhibit A should be represented using the disjunctive OR operator (See: SPDX spec, section on SPDX License Expressions and https://www.eclipse.org/legal/epl-2.0/faq.php for more info).\n\n",
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LINUX_MAN_PAGES_1_PARA = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Linux-man-pages-1-para"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://git.kernel.org/pub/scm/docs/man-pages/man-pages.git/tree/man2/getcpu.2#n4")
        ],
        LicenseText = ReadResource("Linux-man-pages-1-para.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Linux-man-pages-1-para.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense HIDAPI = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/HIDAPI"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/signal11/hidapi/blob/master/LICENSE-orig.txt")
        ],
        LicenseText = ReadResource("HIDAPI.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("HIDAPI.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OSL_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OSL-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/OSL-1.0")
        ],
        LicenseText = ReadResource("OSL-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OSL-1.0.template.txt"),
        StandardLicenseHeader = ReadResource("OSL-1.0.header.txt"),
        Comment = "This license has been superseded.",
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense ARTISTIC_1_0_PERL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Artistic-1.0-Perl"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://dev.perl.org/licenses/artistic.html")
        ],
        LicenseText = ReadResource("Artistic-1.0-Perl.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Artistic-1.0-Perl.template.txt"),
        Comment = "This is the Artistic License 1.0 found on the Perl site, which is different (particularly, clauses 5, 6, 7 and 8) than the Artistic License 1.0 w/clause 8 found on the OSI site.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense XPP = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/xpp"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/xpp")
        ],
        LicenseText = ReadResource("xpp.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("xpp.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense XFIG = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Xfig"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/Distrotech/transfig/blob/master/transfig/transfig.c"),
            new Uri("https://fedoraproject.org/wiki/Licensing:MIT#Xfig_Variant"),
            new Uri("https://sourceforge.net/p/mcj/xfig/ci/master/tree/src/Makefile.am")
        ],
        LicenseText = ReadResource("Xfig.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Xfig.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CDL_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CDL-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.opensource.apple.com/cdl/"),
            new Uri("https://fedoraproject.org/wiki/Licensing/Common_Documentation_License"),
            new Uri("https://www.gnu.org/licenses/license-list.html#ACDL")
        ],
        LicenseText = ReadResource("CDL-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CDL-1.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense TAPR_OHL_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/TAPR-OHL-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.tapr.org/OHL")
        ],
        LicenseText = ReadResource("TAPR-OHL-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("TAPR-OHL-1.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BSD_ATTRIBUTION_HPND_DISCLAIMER = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/BSD-Attribution-HPND-disclaimer"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/cyrusimap/cyrus-sasl/blob/master/COPYING")
        ],
        LicenseText = ReadResource("BSD-Attribution-HPND-disclaimer.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("BSD-Attribution-HPND-disclaimer.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GFDL_1_3_NO_INVARIANTS_ONLY = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GFDL-1.3-no-invariants-only"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/fdl-1.3.txt")
        ],
        LicenseText = ReadResource("GFDL-1.3-no-invariants-only.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GFDL-1.3-no-invariants-only.template.txt"),
        StandardLicenseHeader = ReadResource("GFDL-1.3-no-invariants-only.header.txt"),
        Comment = "This license was released 3 November 2008. The identifier GFDL-1.3-only-no-invariants should only be used when there are no Invariant Sections, Front-Cover Texts or Back-Cover Texts. See GFDL-1.3-only and GFDL-1.3-only-invariants for alternatives.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense _3D_SLICER_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/3D-Slicer-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://slicer.org/LICENSE"),
            new Uri("https://github.com/Slicer/Slicer/blob/main/License.txt")
        ],
        LicenseText = ReadResource("3D-Slicer-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("3D-Slicer-1.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_3_0_US = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-3.0-US"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by/3.0/us/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-3.0-US.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-3.0-US.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense THIRDEYE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/ThirdEye"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://sourceware.org/cgit/binutils-gdb/tree/include/coff/symconst.h#n11")
        ],
        LicenseText = ReadResource("ThirdEye.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("ThirdEye.template.txt"),
        Comment = "This is a variant to MIPS license with extra paragraph.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense MMIXWARE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/MMIXware"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://gitlab.lrz.de/mmix/mmixware/-/blob/master/boilerplate.w")
        ],
        LicenseText = ReadResource("MMIXware.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("MMIXware.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense ODBL_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/ODbL-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.opendatacommons.org/licenses/odbl/1.0/"),
            new Uri("https://opendatacommons.org/licenses/odbl/1-0/")
        ],
        LicenseText = ReadResource("ODbL-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("ODbL-1.0.template.txt"),
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OLDAP_2_7 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OLDAP-2.7"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.openldap.org/devel/gitweb.cgi?p=openldap.git;a=blob;f=LICENSE;hb=47c2415c1df81556eeb39be6cad458ef87c534a2")
        ],
        LicenseText = ReadResource("OLDAP-2.7.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OLDAP-2.7.template.txt"),
        Comment = "This license was released 7 September 2001.",
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GFDL_1_1_OR_LATER = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GFDL-1.1-or-later"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/old-licenses/fdl-1.1.txt")
        ],
        LicenseText = ReadResource("GFDL-1.1-or-later.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GFDL-1.1-or-later.template.txt"),
        StandardLicenseHeader = ReadResource("GFDL-1.1-or-later.header.txt"),
        Comment = "This license was released March 2000. The identifier GFDL-1.1-or-later can be used to indicate that this license applies, without asserting whether or not any Invariant Sections, Front-Cover Texts or Back-Cover Texts are present. See GFDL-1.1-or-later-invariants and GFDL-1.1-or-later-no-invariants for alternative identifiers that can be used to express explicitly that these sections or cover texts are present or are not present, respectively.",
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense PLEXUS = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Plexus"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/Plexus_Classworlds_License")
        ],
        LicenseText = ReadResource("Plexus.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Plexus.template.txt"),
        Comment = "dom4j uses this same license.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CFITSIO = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CFITSIO"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://heasarc.gsfc.nasa.gov/docs/software/fitsio/c/f_user/node9.html"),
            new Uri("https://heasarc.gsfc.nasa.gov/docs/software/ftools/fv/doc/license.html")
        ],
        LicenseText = ReadResource("CFITSIO.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CFITSIO.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense WIDGET_WORKSHOP = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Widget-Workshop"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/novnc/noVNC/blob/master/core/crypto/des.js#L24")
        ],
        LicenseText = ReadResource("Widget-Workshop.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Widget-Workshop.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense NOSL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/NOSL"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://bits.netizen.com.au/licenses/NOSL/nosl.txt")
        ],
        LicenseText = ReadResource("NOSL.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("NOSL.template.txt"),
        Comment = "This license is essentially a rebranded version of MPL-1.1, but with some important changes. The added §7.1 expands on the warranty disclaimer. The change in §11 moves the forum and the jurisdiction to Victoria, Australia (from California, USA in MPL-1.1). Section 3.7 of this license contains the word \"LEDs\" which appears to be a typo in the upstream version, at https://directory.fsf.org/wiki/License:NOSL. It is retained here as optional text, so that it will still match in case others have used the license text with this typo.",
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CAL_1_0_COMBINED_WORK_EXCEPTION = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CAL-1.0-Combined-Work-Exception"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://cryptographicautonomylicense.com/license-text.html"),
            new Uri("https://opensource.org/licenses/CAL-1.0")
        ],
        LicenseText = ReadResource("CAL-1.0-Combined-Work-Exception.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CAL-1.0-Combined-Work-Exception.template.txt"),
        Comment = "The first draft of this license was released February 2019, and the fourth revision was approved by the OSI February 2020. This license list entry is for use when the work is subject to the \"Combined Work Exception\" as described in section 4.5.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GFDL_1_2_OR_LATER = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GFDL-1.2-or-later"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/old-licenses/fdl-1.2.txt")
        ],
        LicenseText = ReadResource("GFDL-1.2-or-later.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GFDL-1.2-or-later.template.txt"),
        StandardLicenseHeader = ReadResource("GFDL-1.2-or-later.header.txt"),
        Comment = "This license was released November 2002. The identifier GFDL-1.2-or-later can be used to indicate that this license applies, without asserting whether or not any Invariant Sections, Front-Cover Texts or Back-Cover Texts are present. See GFDL-1.2-or-later-invariants and GFDL-1.2-or-later-no-invariants for alternative identifiers that can be used to express explicitly that these sections or cover texts are present or are not present, respectively.",
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BSD_4_3RENO = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/BSD-4.3RENO"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://sourceware.org/git/?p=binutils-gdb.git;a=blob;f=libiberty/strcasecmp.c;h=131d81c2ce7881fa48c363dc5bf5fb302c61ce0b;hb=HEAD"),
            new Uri("https://git.openldap.org/openldap/openldap/-/blob/master/COPYRIGHT#L55-63")
        ],
        LicenseText = ReadResource("BSD-4.3RENO.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("BSD-4.3RENO.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SGI_B_1_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/SGI-B-1.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://oss.sgi.com/projects/FreeB/")
        ],
        LicenseText = ReadResource("SGI-B-1.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("SGI-B-1.1.template.txt"),
        StandardLicenseHeader = ReadResource("SGI-B-1.1.header.txt"),
        Comment = "This license was released 22 February 2002",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_3_0_AT = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-3.0-AT"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by/3.0/at/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-3.0-AT.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-3.0-AT.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CLARTISTIC = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/ClArtistic"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://gianluca.dellavedova.org/2011/01/03/clarified-artistic-license/"),
            new Uri("http://www.ncftp.com/ncftp/doc/LICENSE.txt")
        ],
        LicenseText = ReadResource("ClArtistic.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("ClArtistic.template.txt"),
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense DL_DE_BY_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/DL-DE-BY-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.govdata.de/dl-de/by-2-0")
        ],
        LicenseText = ReadResource("DL-DE-BY-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("DL-DE-BY-2.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OGL_UK_3_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OGL-UK-3.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.nationalarchives.gov.uk/doc/open-government-licence/version/3/")
        ],
        LicenseText = ReadResource("OGL-UK-3.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OGL-UK-3.0.template.txt"),
        Comment = "A Welsh translation of this license is available: http://www.nationalarchives.gov.uk/doc/open-government-licence-cymraeg/version/3/",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense PSF_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/PSF-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/Python-2.0"),
            new Uri("https://matplotlib.org/stable/project/license.html")
        ],
        LicenseText = ReadResource("PSF-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("PSF-2.0.template.txt"),
        Comment = "This is the PSF-2.0 license, which is part of the complete Python license text, but also used independently by some projects, for example, matplotlib.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LATEX2E = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Latex2e"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/Latex2e")
        ],
        LicenseText = ReadResource("Latex2e.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Latex2e.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_SA_3_0_IGO = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-SA-3.0-IGO"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by-sa/3.0/igo/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-SA-3.0-IGO.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-SA-3.0-IGO.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense DOCBOOK_XML = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/DocBook-XML"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/docbook/xslt10-stylesheets/blob/efd62655c11cc8773708df7a843613fa1e932bf8/xsl/COPYING#L27")
        ],
        LicenseText = ReadResource("DocBook-XML.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("DocBook-XML.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BSD_3_CLAUSE_SUN = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/BSD-3-Clause-Sun"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/xmlark/msv/blob/b9316e2f2270bc1606952ea4939ec87fbba157f3/xsdlib/src/main/java/com/sun/msv/datatype/regexp/InternalImpl.java")
        ],
        LicenseText = ReadResource("BSD-3-Clause-Sun.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("BSD-3-Clause-Sun.template.txt"),
        Comment = "This license is very similar to BSD-3-Clause-No-Nuclear-Warranty except it has variations in the disclaimer and omits the no-nuclear-warranty at the end.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BSD_2_CLAUSE_VIEWS = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/BSD-2-Clause-Views"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.freebsd.org/copyright/freebsd-license.html"),
            new Uri("https://people.freebsd.org/~ivoras/wine/patch-wine-nvidia.sh"),
            new Uri("https://github.com/protegeproject/protege/blob/master/license.txt")
        ],
        LicenseText = ReadResource("BSD-2-Clause-Views.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("BSD-2-Clause-Views.template.txt"),
        Comment = "This is a more generalized version of BSD-2-Clause-FreeBSD, which is now deprecated. It is identical to BSD-2-Clause with the addition of the \"views and conclusions\" sentence at the end.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LIBUTIL_DAVID_NUGENT = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/libutil-David-Nugent"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://web.mit.edu/freebsd/head/lib/libutil/login_ok.3"),
            new Uri("https://cgit.freedesktop.org/libbsd/tree/man/setproctitle.3bsd")
        ],
        LicenseText = ReadResource("libutil-David-Nugent.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("libutil-David-Nugent.template.txt"),
        Comment = "This is a legacy BSD-like license, but includes a specific requirement in the first clause requiring retention of the copyright notice \"immediately at the beginning of the file\".",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BZIP2_1_0_6 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/bzip2-1.0.6"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://sourceware.org/git/?p=bzip2.git;a=blob;f=LICENSE;hb=bzip2-1.0.6"),
            new Uri("http://bzip.org/1.0.5/bzip2-manual-1.0.5.html"),
            new Uri("https://sourceware.org/cgit/valgrind/tree/mpi/libmpiwrap.c")
        ],
        LicenseText = ReadResource("bzip2-1.0.6.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("bzip2-1.0.6.template.txt"),
        Comment = "The additional \"Neither the names of...\" optional clause at the end of the license occurs in certain uses of this license text, as described at https://github.com/spdx/license-list-XML/issues/2271",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by/2.0/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-2.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SISSL_1_2 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/SISSL-1.2"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://gridscheduler.sourceforge.net/Gridengine_SISSL_license.html")
        ],
        LicenseText = ReadResource("SISSL-1.2.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("SISSL-1.2.template.txt"),
        StandardLicenseHeader = ReadResource("SISSL-1.2.header.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_4_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-4.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by/4.0/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-4.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-4.0.template.txt"),
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense HPND_SELL_VARIANT_MIT_DISCLAIMER = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/HPND-sell-variant-MIT-disclaimer"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/sigmavirus24/x11-ssh-askpass/blob/master/README")
        ],
        LicenseText = ReadResource("HPND-sell-variant-MIT-disclaimer.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("HPND-sell-variant-MIT-disclaimer.template.txt"),
        Comment = "This license is comprised of parts of the permission language from HPND-sell-variant and the disclaimer from MIT.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense ANTLR_PD = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/ANTLR-PD"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.antlr2.org/license.html")
        ],
        LicenseText = ReadResource("ANTLR-PD.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("ANTLR-PD.template.txt"),
        Comment = "ANTLR used this public domain notice through version 2.7 and then switched to a BSD license for version 3.0 and later.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SCEA = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/SCEA"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://research.scea.com/scea_shared_source_license.html")
        ],
        LicenseText = ReadResource("SCEA.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("SCEA.template.txt"),
        StandardLicenseHeader = ReadResource("SCEA.header.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense ADOBE_2006 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Adobe-2006"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/AdobeLicense")
        ],
        LicenseText = ReadResource("Adobe-2006.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Adobe-2006.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BORCEUX = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Borceux"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/Borceux")
        ],
        LicenseText = ReadResource("Borceux.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Borceux.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense DOC = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/DOC"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.cs.wustl.edu/~schmidt/ACE-copying.html"),
            new Uri("https://www.dre.vanderbilt.edu/~schmidt/ACE-copying.html")
        ],
        LicenseText = ReadResource("DOC.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("DOC.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_PDM_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-PDM-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/publicdomain/mark/1.0/"),
            new Uri("https://creativecommons.org/share-your-work/cclicenses/")
        ],
        LicenseText = ReadResource("CC-PDM-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-PDM-1.0.template.txt"),
        Comment = "As per Creative Commons, this is intended to provide a standard way to mark works that are no longer restricted by copyright to be marked as such in a standard and simple way. See https://creativecommons.org/public-domain/pdm/ for more information.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BZIP2_1_0_5 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/bzip2-1.0.5"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://sourceware.org/bzip2/1.0.5/bzip2-manual-1.0.5.html"),
            new Uri("http://bzip.org/1.0.5/bzip2-manual-1.0.5.html")
        ],
        LicenseText = ReadResource("bzip2-1.0.5.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("bzip2-1.0.5.template.txt"),
        Comment = "bzip2-1.0.5 is being deprecated in favor of bzip2-1.0.6, which is now equivalent as of License List version 3.16 with the addition of markup for version numbering and the optional PATENTS statement, which was not specific to bzip2 1.0.5.",
        IsDeprecatedLicenseId = true,
        DeprecatedVersion = "3.16",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CPOL_1_02 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CPOL-1.02"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.codeproject.com/info/cpol10.aspx")
        ],
        LicenseText = ReadResource("CPOL-1.02.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CPOL-1.02.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_ND_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-ND-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by-nd/1.0/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-ND-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-ND-1.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense NCGL_UK_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/NCGL-UK-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.nationalarchives.gov.uk/doc/non-commercial-government-licence/version/2/")
        ],
        LicenseText = ReadResource("NCGL-UK-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("NCGL-UK-2.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense COPYLEFT_NEXT_0_3_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/copyleft-next-0.3.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/copyleft-next/copyleft-next/blob/master/Releases/copyleft-next-0.3.0")
        ],
        LicenseText = ReadResource("copyleft-next-0.3.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("copyleft-next-0.3.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense INNOSETUP = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/InnoSetup"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/jrsoftware/issrc/blob/HEAD/license.txt")
        ],
        LicenseText = ReadResource("InnoSetup.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("InnoSetup.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GPL_1_0_OR_LATER = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GPL-1.0-or-later"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/old-licenses/gpl-1.0-standalone.html")
        ],
        LicenseText = ReadResource("GPL-1.0-or-later.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GPL-1.0-or-later.template.txt"),
        StandardLicenseHeader = ReadResource("GPL-1.0-or-later.header.txt"),
        Comment = "This license was released: February 1989. This license identifier refers to the choice to use code under GPL-1.0-or-later (i.e., GPL-1.0 or some later version), as distinguished from the use of code under GPL-1.0-only. The license notice (as seen in the Standard License Header field below) states which of these applies to the code in the file. The example in the How to Apply These Terms appendix of the license shows the \"or later\" approach.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CATHARON = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Catharon"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/scummvm/scummvm/blob/v2.8.0/LICENSES/CatharonLicense.txt")
        ],
        LicenseText = ReadResource("Catharon.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Catharon.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_NC_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-NC-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by-nc/1.0/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-NC-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-NC-1.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense MIPS = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/MIPS"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://sourceware.org/cgit/binutils-gdb/tree/include/coff/sym.h#n11")
        ],
        LicenseText = ReadResource("MIPS.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("MIPS.template.txt"),
        Comment = "This is shorter version of ThirdEye license.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense COPYLEFT_NEXT_0_3_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/copyleft-next-0.3.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/copyleft-next/copyleft-next/blob/master/Releases/copyleft-next-0.3.1")
        ],
        LicenseText = ReadResource("copyleft-next-0.3.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("copyleft-next-0.3.1.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense HPND_INRIA_IMAG = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/HPND-INRIA-IMAG"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/ppp-project/ppp/blob/master/pppd/ipv6cp.c#L75-L83")
        ],
        LicenseText = ReadResource("HPND-INRIA-IMAG.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("HPND-INRIA-IMAG.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense ISC_VEILLARD = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/ISC-Veillard"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://raw.githubusercontent.com/GNOME/libxml2/4c2e7c651f6c2f0d1a74f350cbda95f7df3e7017/hash.c"),
            new Uri("https://github.com/GNOME/libxml2/blob/master/dict.c"),
            new Uri("https://sourceforge.net/p/ctrio/git/ci/master/tree/README")
        ],
        LicenseText = ReadResource("ISC-Veillard.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("ISC-Veillard.template.txt"),
        Comment = "This license uses the same grant as ISC, but a different disclaimer paragraph. It appears to originate from the Trio printf library.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GFDL_1_3_NO_INVARIANTS_OR_LATER = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GFDL-1.3-no-invariants-or-later"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/fdl-1.3.txt")
        ],
        LicenseText = ReadResource("GFDL-1.3-no-invariants-or-later.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GFDL-1.3-no-invariants-or-later.template.txt"),
        StandardLicenseHeader = ReadResource("GFDL-1.3-no-invariants-or-later.header.txt"),
        Comment = "This license was released 3 November 2008. The identifier GFDL-1.3-or-later-no-invariants should only be used when there are no Invariant Sections, Front-Cover Texts or Back-Cover Texts. See GFDL-1.3-or-later and GFDL-1.3-or-later-invariants for alternatives.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_3_0_NL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-3.0-NL"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by/3.0/nl/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-3.0-NL.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-3.0-NL.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_ND_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-ND-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by-nd/2.0/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-ND-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-ND-2.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CRYPTOSWIFT = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CryptoSwift"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/krzyzanowskim/CryptoSwift/blob/main/LICENSE")
        ],
        LicenseText = ReadResource("CryptoSwift.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CryptoSwift.template.txt"),
        Comment = "This license is similar to Cube and zlib, but adds an acknowledgment requirement.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BSD_3_CLAUSE_HP = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/BSD-3-Clause-HP"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/zdohnal/hplip/blob/master/COPYING#L939")
        ],
        LicenseText = ReadResource("BSD-3-Clause-HP.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("BSD-3-Clause-HP.template.txt"),
        Comment = "This license is almost identical to BSD-3-Clause, but adds \"patent infringement\" to the disclaimer.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CATOSL_1_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CATOSL-1.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/CATOSL-1.1")
        ],
        LicenseText = ReadResource("CATOSL-1.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CATOSL-1.1.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense NCSA = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/NCSA"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://otm.illinois.edu/uiuc_openSource"),
            new Uri("https://opensource.org/licenses/NCSA")
        ],
        LicenseText = ReadResource("NCSA.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("NCSA.template.txt"),
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SPENCER_99 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Spencer-99"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.opensource.apple.com/source/tcl/tcl-5/tcl/generic/regfronts.c")
        ],
        LicenseText = ReadResource("Spencer-99.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Spencer-99.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense DRL_1_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/DRL-1.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/SigmaHQ/Detection-Rule-License/blob/6ec7fbde6101d101b5b5d1fcb8f9b69fbc76c04a/LICENSE.Detection.Rules.md")
        ],
        LicenseText = ReadResource("DRL-1.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("DRL-1.1.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BSD_3_CLAUSE_NO_NUCLEAR_LICENSE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/BSD-3-Clause-No-Nuclear-License"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://download.oracle.com/otn-pub/java/licenses/bsd.txt")
        ],
        LicenseText = ReadResource("BSD-3-Clause-No-Nuclear-License.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("BSD-3-Clause-No-Nuclear-License.template.txt"),
        Comment = "This license has an older Sun copyright notice and is the same license as BSD-3-Clause-No-Nuclear-Warranty, except it specifies that that software is \"not licensed\" for use in a nuclear facility, as opposed to a disclaimer for such use.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense MIT_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/MIT-0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/aws/mit-0"),
            new Uri("https://romanrm.net/mit-zero"),
            new Uri("https://github.com/awsdocs/aws-cloud9-user-guide/blob/master/LICENSE-SAMPLECODE")
        ],
        LicenseText = ReadResource("MIT-0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("MIT-0.template.txt"),
        Comment = "This license is a modified version of the common MIT license, with the attribution paragraph removed.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SENDMAIL_8_23 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Sendmail-8.23"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.proofpoint.com/sites/default/files/sendmail-license.pdf"),
            new Uri("https://web.archive.org/web/20181003101040/https://www.proofpoint.com/sites/default/files/sendmail-license.pdf")
        ],
        LicenseText = ReadResource("Sendmail-8.23.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Sendmail-8.23.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense X11_DISTRIBUTE_MODIFICATIONS_VARIANT = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/X11-distribute-modifications-variant"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/mirror/ncurses/blob/master/COPYING")
        ],
        LicenseText = ReadResource("X11-distribute-modifications-variant.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("X11-distribute-modifications-variant.template.txt"),
        Comment = "This is same as X11, but with an additional \"distribute with modifications\" grant and does not have the trademark at the end.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense DOTSEQN = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Dotseqn"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/Dotseqn")
        ],
        LicenseText = ReadResource("Dotseqn.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Dotseqn.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OGL_UK_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OGL-UK-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.nationalarchives.gov.uk/doc/open-government-licence/version/1/")
        ],
        LicenseText = ReadResource("OGL-UK-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OGL-UK-1.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense EUPL_1_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/EUPL-1.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://joinup.ec.europa.eu/software/page/eupl/licence-eupl"),
            new Uri("https://joinup.ec.europa.eu/sites/default/files/custom-page/attachment/eupl1.1.-licence-en_0.pdf"),
            new Uri("https://opensource.org/licenses/EUPL-1.1")
        ],
        LicenseText = ReadResource("EUPL-1.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("EUPL-1.1.template.txt"),
        Comment = "This license was released: 16 May 2008 This license is available in the 22 official languages of the EU. The English version is included here.",
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense APP_S2P = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/App-s2p"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/App-s2p")
        ],
        LicenseText = ReadResource("App-s2p.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("App-s2p.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense VIM = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Vim"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://vimdoc.sourceforge.net/htmldoc/uganda.html")
        ],
        LicenseText = ReadResource("Vim.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Vim.template.txt"),
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_ND_3_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-ND-3.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by-nd/3.0/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-ND-3.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-ND-3.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense UNLICENSE_LIBWHIRLPOOL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Unlicense-libwhirlpool"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/dfateyev/libwhirlpool/blob/master/README#L27")
        ],
        LicenseText = ReadResource("Unlicense-libwhirlpool.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Unlicense-libwhirlpool.template.txt"),
        Comment = "This is similar to the Unlicense, but removes the middle paragraph entirely and the last sentence.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense MIT_ADVERTISING = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/MIT-advertising"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/MIT_With_Advertising")
        ],
        LicenseText = ReadResource("MIT-advertising.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("MIT-advertising.template.txt"),
        Comment = "This license is a modified version of the common MIT license, with an additional advertising clause",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense MAGAZ = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/magaz"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://mirrors.nic.cz/tex-archive/macros/latex/contrib/magaz/magaz.tex"),
            new Uri("https://mirrors.ctan.org/macros/latex/contrib/version/version.sty")
        ],
        LicenseText = ReadResource("magaz.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("magaz.template.txt"),
        Comment = "This license is a very similar to ulem and fwlw, but has slightly different obligations.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense IJG_SHORT = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/IJG-short"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://sourceforge.net/p/xmedcon/code/ci/master/tree/libs/ljpg/")
        ],
        LicenseText = ReadResource("IJG-short.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("IJG-short.template.txt"),
        Comment = "This license is a shorter, presumably earlier version of IJG",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_SA_4_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-SA-4.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by-sa/4.0/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-SA-4.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-SA-4.0.template.txt"),
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SAXPATH = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Saxpath"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/Saxpath_License")
        ],
        LicenseText = ReadResource("Saxpath.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Saxpath.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense ASWF_DIGITAL_ASSETS_1_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/ASWF-Digital-Assets-1.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/AcademySoftwareFoundation/foundation/blob/main/digital_assets/aswf_digital_assets_license_v1.1.txt")
        ],
        LicenseText = ReadResource("ASWF-Digital-Assets-1.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("ASWF-Digital-Assets-1.1.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_NC_SA_2_0_UK = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-NC-SA-2.0-UK"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by-nc-sa/2.0/uk/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-NC-SA-2.0-UK.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-NC-SA-2.0-UK.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense NCBI_PD = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/NCBI-PD"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/ncbi/sra-tools/blob/e8e5b6af4edc460156ad9ce5902d0779cffbf685/LICENSE"),
            new Uri("https://github.com/ncbi/datasets/blob/0ea4cd16b61e5b799d9cc55aecfa016d6c9bd2bf/LICENSE.md"),
            new Uri("https://github.com/ncbi/gprobe/blob/de64d30fee8b4c4013094d7d3139ea89b5dd1ace/LICENSE"),
            new Uri("https://github.com/ncbi/egapx/blob/08930b9dec0c69b2d1a05e5153c7b95ef0a3eb0f/LICENSE"),
            new Uri("https://github.com/ncbi/datasets/blob/master/LICENSE.md")
        ],
        LicenseText = ReadResource("NCBI-PD.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("NCBI-PD.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LZMA_SDK_9_22 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/LZMA-SDK-9.22"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.7-zip.org/sdk.html"),
            new Uri("https://sourceforge.net/projects/sevenzip/files/LZMA%20SDK/")
        ],
        LicenseText = ReadResource("LZMA-SDK-9.22.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("LZMA-SDK-9.22.template.txt"),
        Comment = "The license text currently displayed on the 7-zip SDK website is not the same as any of the lzma.txt file in the root folders of the .tar.bz SDK distributions (versions 922 and below) that are hosted on SourceForge, nor is it the same as the .7z distributions (versions 935 and above) which shifted the license text to DOC\\lzma-sdk.txt. This license applies to versions 9.22 and above.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LPL_1_02 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/LPL-1.02"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://plan9.bell-labs.com/plan9/license.html"),
            new Uri("https://opensource.org/licenses/LPL-1.02")
        ],
        LicenseText = ReadResource("LPL-1.02.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("LPL-1.02.template.txt"),
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GFDL_1_2_NO_INVARIANTS_OR_LATER = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GFDL-1.2-no-invariants-or-later"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/old-licenses/fdl-1.2.txt")
        ],
        LicenseText = ReadResource("GFDL-1.2-no-invariants-or-later.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GFDL-1.2-no-invariants-or-later.template.txt"),
        StandardLicenseHeader = ReadResource("GFDL-1.2-no-invariants-or-later.header.txt"),
        Comment = "This license was released November 2002. The identifier GFDL-1.2-or-later-no-invariants should only be used when there are no Invariant Sections, Front-Cover Texts or Back-Cover Texts. See GFDL-1.2-or-later and GFDL-1.2-or-later-invariants for alternatives.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_NC_SA_3_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-NC-SA-3.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by-nc-sa/3.0/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-NC-SA-3.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-NC-SA-3.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CPAL_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CPAL-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/CPAL-1.0")
        ],
        LicenseText = ReadResource("CPAL-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CPAL-1.0.template.txt"),
        StandardLicenseHeader = ReadResource("CPAL-1.0.header.txt"),
        Comment = "This license is essentially a rebranded version of MPL-1.1, but with some important changes. The added §14 includes an advertising clause, and in order for that CPAL-1.0 introduces the concept of an \"Original Developer\" (\"organizer of the development of the Original Code\"). The added §15 extends the (weak) copyleft also to trigger on network use.",
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OLDAP_2_6 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OLDAP-2.6"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.openldap.org/devel/gitweb.cgi?p=openldap.git;a=blob;f=LICENSE;hb=1cae062821881f41b73012ba816434897abf4205")
        ],
        LicenseText = ReadResource("OLDAP-2.6.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OLDAP-2.6.template.txt"),
        Comment = "This license was released 14 June 2001.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense APSL_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/APSL-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/Apple_Public_Source_License_1.0")
        ],
        LicenseText = ReadResource("APSL-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("APSL-1.0.template.txt"),
        Comment = "This license was released 16 March 1999.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GTKBOOK = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/gtkbook"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/slogan621/gtkbook"),
            new Uri("https://github.com/oetiker/rrdtool-1.x/blob/master/src/plbasename.c#L8-L11")
        ],
        LicenseText = ReadResource("gtkbook.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("gtkbook.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense MPI_PERMISSIVE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/mpi-permissive"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://sources.debian.org/src/openmpi/4.1.0-10/ompi/debuggers/msgq_interface.h/?hl=19#L19")
        ],
        LicenseText = ReadResource("mpi-permissive.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("mpi-permissive.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense APL_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/APL-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/APL-1.0")
        ],
        LicenseText = ReadResource("APL-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("APL-1.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CHECKMK = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/checkmk"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/libcheck/check/blob/master/checkmk/checkmk.in")
        ],
        LicenseText = ReadResource("checkmk.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("checkmk.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BSD_3_CLAUSE_FLEX = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/BSD-3-Clause-flex"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/westes/flex/blob/master/COPYING")
        ],
        LicenseText = ReadResource("BSD-3-Clause-flex.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("BSD-3-Clause-flex.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense EPICS = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/EPICS"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://epics.anl.gov/license/open.php")
        ],
        LicenseText = ReadResource("EPICS.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("EPICS.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense PSFRAG = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/psfrag"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/psfrag")
        ],
        LicenseText = ReadResource("psfrag.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("psfrag.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense HPND_MARKUS_KUHN = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/HPND-Markus-Kuhn"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.cl.cam.ac.uk/~mgk25/ucs/wcwidth.c"),
            new Uri("https://sourceware.org/git/?p=binutils-gdb.git;a=blob;f=readline/readline/support/wcwidth.c;h=0f5ec995796f4813abbcf4972aec0378ab74722a;hb=HEAD#l55")
        ],
        LicenseText = ReadResource("HPND-Markus-Kuhn.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("HPND-Markus-Kuhn.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GPL_3_0_WITH_AUTOCONF_EXCEPTION = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GPL-3.0-with-autoconf-exception"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/autoconf-exception-3.0.html")
        ],
        LicenseText = ReadResource("GPL-3.0-with-autoconf-exception.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GPL-3.0-with-autoconf-exception.template.txt"),
        Comment = "DEPRECATED: Use license expression including main license, \"WITH\" operator, and identifier: Autoconf-exception-3.0",
        IsDeprecatedLicenseId = true,
        DeprecatedVersion = "2.0rc2",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LIBTIFF = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/libtiff"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/libtiff")
        ],
        LicenseText = ReadResource("libtiff.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("libtiff.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense MAN2HTML = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/man2html"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://primates.ximian.com/~flucifredi/man/man-1.6g.tar.gz"),
            new Uri("https://github.com/hamano/man2html/blob/master/man2html.c"),
            new Uri("https://docs.oracle.com/cd/E81115_01/html/E81116/licenses.html")
        ],
        LicenseText = ReadResource("man2html.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("man2html.template.txt"),
        Comment = "This license is very similar to check-cvs.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense ADACORE_DOC = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/AdaCore-doc"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/AdaCore/xmlada/blob/master/docs/index.rst"),
            new Uri("https://github.com/AdaCore/gnatcoll-core/blob/master/docs/index.rst"),
            new Uri("https://github.com/AdaCore/gnatcoll-db/blob/master/docs/index.rst")
        ],
        LicenseText = ReadResource("AdaCore-doc.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("AdaCore-doc.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_2_5 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-2.5"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by/2.5/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-2.5.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-2.5.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense MIT_ENNA = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/MIT-enna"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/MIT#enna")
        ],
        LicenseText = ReadResource("MIT-enna.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("MIT-enna.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BLUEOAK_1_0_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/BlueOak-1.0.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://blueoakcouncil.org/license/1.0.0")
        ],
        LicenseText = ReadResource("BlueOak-1.0.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("BlueOak-1.0.0.template.txt"),
        Comment = "This license was released on March 6, 2019.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense W3C = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/W3C"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.w3.org/Consortium/Legal/2002/copyright-software-20021231.html"),
            new Uri("https://opensource.org/licenses/W3C")
        ],
        LicenseText = ReadResource("W3C.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("W3C.template.txt"),
        StandardLicenseHeader = ReadResource("W3C.header.txt"),
        Comment = "This license was released: 13 December 2002. The standard header is provided via a link from the original license page.",
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense PARITY_6_0_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Parity-6.0.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://paritylicense.com/versions/6.0.0.html")
        ],
        LicenseText = ReadResource("Parity-6.0.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Parity-6.0.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LPPL_1_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/LPPL-1.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.latex-project.org/lppl/lppl-1-1.txt")
        ],
        LicenseText = ReadResource("LPPL-1.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("LPPL-1.1.template.txt"),
        StandardLicenseHeader = ReadResource("LPPL-1.1.header.txt"),
        Comment = "This license was released 10 July 1999.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense QHULL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Qhull"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/Qhull")
        ],
        LicenseText = ReadResource("Qhull.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Qhull.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense X11_SWAPPED = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/X11-swapped"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/fedeinthemix/chez-srfi/blob/master/srfi/LICENSE")
        ],
        LicenseText = ReadResource("X11-swapped.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("X11-swapped.template.txt"),
        Comment = "This is same as X11, but the order of the last two paragraphs is swapped.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense XFREE86_1_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/XFree86-1.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.xfree86.org/current/LICENSE4.html")
        ],
        LicenseText = ReadResource("XFree86-1.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("XFree86-1.1.template.txt"),
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense KASTRUP = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Kastrup"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://ctan.math.utah.edu/ctan/tex-archive/macros/generic/kastrup/binhex.dtx")
        ],
        LicenseText = ReadResource("Kastrup.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Kastrup.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense STANDARDML_NJ = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/StandardML-NJ"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.smlnj.org/license.html")
        ],
        LicenseText = ReadResource("StandardML-NJ.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("StandardML-NJ.template.txt"),
        Comment = "DEPRECATED: Duplicate license, use identifier: SMLNJ",
        IsFsfLibre = true,
        IsOsiApproved = false,
        IsDeprecatedLicenseId = true,
        DeprecatedVersion = "2.0rc2",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense AAL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/AAL"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/attribution")
        ],
        LicenseText = ReadResource("AAL.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("AAL.template.txt"),
        Comment = "This license was released: 2002 Originally written by Edwin A. Suominen for licensing his PRIVARIA secure networking software (see www.privaria.org). The author, who is not an attorney, places this license template into the public domain along with a complete disclaimer of any warranty or responsibility for its content or legal efficacy. You may use or modify the language freely, but entirely at your own risk.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BOEHM_GC = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Boehm-GC"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing:MIT#Another_Minimal_variant_(found_in_libatomic_ops)"),
            new Uri("https://github.com/uim/libgcroots/blob/master/COPYING"),
            new Uri("https://github.com/ivmai/libatomic_ops/blob/master/LICENSE")
        ],
        LicenseText = ReadResource("Boehm-GC.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Boehm-GC.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense FSL_1_1_MIT = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/FSL-1.1-MIT"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fsl.software/FSL-1.1-MIT.template.md")
        ],
        LicenseText = ReadResource("FSL-1.1-MIT.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("FSL-1.1-MIT.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense FBM = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/FBM"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/SWI-Prolog/packages-xpce/blob/161a40cd82004f731ba48024f9d30af388a7edf5/src/img/gifwrite.c#L21-L26")
        ],
        LicenseText = ReadResource("FBM.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("FBM.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense ARTISTIC_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Artistic-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/Artistic-1.0")
        ],
        LicenseText = ReadResource("Artistic-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Artistic-1.0.template.txt"),
        Comment = "This license was superseded by v2.0. This is Artistic License 1.0 as found on OSI site, excluding clause 8.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BSD_SOURCE_CODE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/BSD-Source-Code"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/robbiehanson/CocoaHTTPServer/blob/master/LICENSE.txt")
        ],
        LicenseText = ReadResource("BSD-Source-Code.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("BSD-Source-Code.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_SA_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-SA-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by-sa/1.0/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-SA-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-SA-1.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GLIDE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Glide"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.users.on.net/~triforce/glidexp/COPYING.txt")
        ],
        LicenseText = ReadResource("Glide.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Glide.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CECILL_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CECILL-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.cecill.info/licences/Licence_CeCILL_V1-fr.html")
        ],
        LicenseText = ReadResource("CECILL-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CECILL-1.0.template.txt"),
        Comment = "English translation can be found here: http://www.cecill.info/licences/Licence_CeCILL_V1-US.html",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense DRL_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/DRL-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/Neo23x0/sigma/blob/master/LICENSE.Detection.Rules.md")
        ],
        LicenseText = ReadResource("DRL-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("DRL-1.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LILIQ_R_1_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/LiLiQ-R-1.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.forge.gouv.qc.ca/participez/licence-logicielle/licence-libre-du-quebec-liliq-en-francais/licence-libre-du-quebec-reciprocite-liliq-r-v1-1/"),
            new Uri("http://opensource.org/licenses/LiLiQ-R-1.1")
        ],
        LicenseText = ReadResource("LiLiQ-R-1.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("LiLiQ-R-1.1.template.txt"),
        Comment = "French is the canonical language for this license. An English translation is provided here: https://www.forge.gouv.qc.ca/participez/licence-logicielle/licence-libre-du-quebec-liliq-in-english/quebec-free-and-open-source-licence-reciprocity-liliq-r-v1-1/",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense ECOS_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/eCos-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/ecos-license.html")
        ],
        LicenseText = ReadResource("eCos-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("eCos-2.0.template.txt"),
        Comment = "DEPRECATED: Use license expression including main license, \"WITH\" operator, and identifier: eCos-exception-2.0",
        IsFsfLibre = true,
        IsOsiApproved = false,
        IsDeprecatedLicenseId = true,
        DeprecatedVersion = "2.0rc2",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LIBPNG = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Libpng"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.libpng.org/pub/png/src/libpng-LICENSE.txt")
        ],
        LicenseText = ReadResource("Libpng.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Libpng.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense ZIMBRA_1_3 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Zimbra-1.3"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://web.archive.org/web/20100302225219/http://www.zimbra.com/license/zimbra-public-license-1-3.html")
        ],
        LicenseText = ReadResource("Zimbra-1.3.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Zimbra-1.3.template.txt"),
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense INFO_ZIP = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Info-ZIP"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.info-zip.org/license.html")
        ],
        LicenseText = ReadResource("Info-ZIP.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Info-ZIP.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CECILL_2_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CECILL-2.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.cecill.info/licences/Licence_CeCILL_V2.1-en.html")
        ],
        LicenseText = ReadResource("CECILL-2.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CECILL-2.1.template.txt"),
        Comment = "French version can be found here: http://www.cecill.info/licences/Licence_CeCILL_V2.1-fr.html",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense IPA = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/IPA"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/IPA")
        ],
        LicenseText = ReadResource("IPA.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("IPA.template.txt"),
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BSD_3_CLAUSE_CLEAR = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/BSD-3-Clause-Clear"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://labs.metacarta.com/license-explanation.html#license")
        ],
        LicenseText = ReadResource("BSD-3-Clause-Clear.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("BSD-3-Clause-Clear.template.txt"),
        Comment = "This is same as BSD-3-Clause but with explicit statement as to no patent rights granted in last paragraph.",
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense ERLPL_1_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/ErlPL-1.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.erlang.org/EPLICENSE")
        ],
        LicenseText = ReadResource("ErlPL-1.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("ErlPL-1.1.template.txt"),
        Comment = "This Erlang License is a derivative work of the Mozilla Public License, Version 1.0. It contains terms which differ from the Mozilla Public License, Version 1.0.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CNRI_PYTHON_GPL_COMPATIBLE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CNRI-Python-GPL-Compatible"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.python.org/download/releases/1.6.1/download_win/")
        ],
        LicenseText = ReadResource("CNRI-Python-GPL-Compatible.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CNRI-Python-GPL-Compatible.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OCLC_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OCLC-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.oclc.org/research/activities/software/license/v2final.htm"),
            new Uri("https://opensource.org/licenses/OCLC-2.0")
        ],
        LicenseText = ReadResource("OCLC-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OCLC-2.0.template.txt"),
        StandardLicenseHeader = ReadResource("OCLC-2.0.header.txt"),
        Comment = "This license was released: May 2002",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SWL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/SWL"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/SWL")
        ],
        LicenseText = ReadResource("SWL.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("SWL.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SMPPL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/SMPPL"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/dcblake/SMP/blob/master/Documentation/License.txt")
        ],
        LicenseText = ReadResource("SMPPL.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("SMPPL.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OSL_2_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OSL-2.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://web.archive.org/web/20050212003940/http://www.rosenlaw.com/osl21.htm"),
            new Uri("https://opensource.org/licenses/OSL-2.1")
        ],
        LicenseText = ReadResource("OSL-2.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OSL-2.1.template.txt"),
        StandardLicenseHeader = ReadResource("OSL-2.1.header.txt"),
        Comment = "Same as version 2.0 of this license except with changes to section 10",
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense HPND_SELL_REGEXPR = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/HPND-sell-regexpr"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://gitlab.com/bacula-org/bacula/-/blob/Branch-11.0/bacula/LICENSE-FOSS?ref_type=heads#L245")
        ],
        LicenseText = ReadResource("HPND-sell-regexpr.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("HPND-sell-regexpr.template.txt"),
        Comment = "This is an even shorter variant of HPND-sell than that template allows for.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OFL_1_1_RFN = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OFL-1.1-RFN"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://scripts.sil.org/cms/scripts/page.php?item_id=OFL_web"),
            new Uri("https://opensource.org/licenses/OFL-1.1")
        ],
        LicenseText = ReadResource("OFL-1.1-RFN.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OFL-1.1-RFN.template.txt"),
        Comment = "This license was released 26 February 2007. The identifier OFL-1.1-RFN should only be used when a Reserved Font Name applies. See OFL-1.1 and OFL-1.1-no-RFN for alternatives.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BUSL_1_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/BUSL-1.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://mariadb.com/bsl11/")
        ],
        LicenseText = ReadResource("BUSL-1.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("BUSL-1.1.template.txt"),
        StandardLicenseHeader = ReadResource("BUSL-1.1.header.txt"),
        Comment = "The Business Source License (this document, or the “License”) is not an Open Source license. However, the Licensed Work will eventually be made available under an Open Source License, as stated in this License. This is a paramaterized license. The license parameters are: restrictions on usage, a change date, and the open source license that will govern usage of the software after the change date.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC0_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC0-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/publicdomain/zero/1.0/legalcode")
        ],
        LicenseText = ReadResource("CC0-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC0-1.0.template.txt"),
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense INTERBASE_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Interbase-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://web.archive.org/web/20060319014854/http://info.borland.com/devsupport/interbase/opensource/IPL.html")
        ],
        LicenseText = ReadResource("Interbase-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Interbase-1.0.template.txt"),
        StandardLicenseHeader = ReadResource("Interbase-1.0.header.txt"),
        Comment = "This license is essentially a rebranded version of MPL-1.1, but with some important changes. A new AMENDMENTS section is introduced, which includes an advertisement clause, non-endorsement and no-trademark clauses, as well as product/project naming rules. These changes are summarised in the new §6.4 where it is also explicitly stated that the license is a modificaton on MPL-1.1.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense XSKAT = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/XSkat"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/XSkat_License")
        ],
        LicenseText = ReadResource("XSkat.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("XSkat.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense PSUTILS = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/psutils"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/psutils")
        ],
        LicenseText = ReadResource("psutils.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("psutils.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense HPND_EXPORT_US_ACKNOWLEDGEMENT = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/HPND-export-US-acknowledgement"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/krb5/krb5/blob/krb5-1.21.2-final/NOTICE#L831-L852"),
            new Uri("https://web.mit.edu/kerberos/krb5-1.21/doc/mitK5license.html")
        ],
        LicenseText = ReadResource("HPND-export-US-acknowledgement.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("HPND-export-US-acknowledgement.template.txt"),
        Comment = "This license is similar to HPND-export-US, but has a different obligation relating to notice and different disclaimer.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LILIQ_RPLUS_1_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/LiLiQ-Rplus-1.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.forge.gouv.qc.ca/participez/licence-logicielle/licence-libre-du-quebec-liliq-en-francais/licence-libre-du-quebec-reciprocite-forte-liliq-r-v1-1/"),
            new Uri("http://opensource.org/licenses/LiLiQ-Rplus-1.1")
        ],
        LicenseText = ReadResource("LiLiQ-Rplus-1.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("LiLiQ-Rplus-1.1.template.txt"),
        Comment = "French is the canonical language for this license. An English translation is provided here: https://www.forge.gouv.qc.ca/participez/licence-logicielle/licence-libre-du-quebec-liliq-in-english/quebec-free-and-open-source-licence-strong-reciprocity-liliq-r-v1-1/",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense MACKERRAS_3_CLAUSE_ACKNOWLEDGMENT = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Mackerras-3-Clause-acknowledgment"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/ppp-project/ppp/blob/master/pppd/auth.c#L6-L28")
        ],
        LicenseText = ReadResource("Mackerras-3-Clause-acknowledgment.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Mackerras-3-Clause-acknowledgment.template.txt"),
        Comment = "This is similar to Mackerras-3-Clause, but removes the obligations related to binary distribution and adds an acknowledgement obligation.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense ADOBE_DISPLAY_POSTSCRIPT = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Adobe-Display-PostScript"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://gitlab.freedesktop.org/xorg/xserver/-/blob/master/COPYING?ref_type=heads#L752")
        ],
        LicenseText = ReadResource("Adobe-Display-PostScript.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Adobe-Display-PostScript.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense RDISC = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Rdisc"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/Rdisc_License")
        ],
        LicenseText = ReadResource("Rdisc.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Rdisc.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense INNER_NET_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Inner-Net-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/Inner_Net_License"),
            new Uri("https://sourceware.org/git/?p=glibc.git;a=blob;f=LICENSES;h=530893b1dc9ea00755603c68fb36bd4fc38a7be8;hb=HEAD#l207")
        ],
        LicenseText = ReadResource("Inner-Net-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Inner-Net-2.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense IMLIB2 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Imlib2"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://trac.enlightenment.org/e/browser/trunk/imlib2/COPYING"),
            new Uri("https://git.enlightenment.org/legacy/imlib2.git/tree/COPYING")
        ],
        LicenseText = ReadResource("Imlib2.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Imlib2.template.txt"),
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense HPND_SELL_VARIANT = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/HPND-sell-variant"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://git.kernel.org/pub/scm/linux/kernel/git/torvalds/linux.git/tree/net/sunrpc/auth_gss/gss_generic_token.c?h=v4.19"),
            new Uri("https://github.com/kfish/xsel/blob/master/COPYING")
        ],
        LicenseText = ReadResource("HPND-sell-variant.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("HPND-sell-variant.template.txt"),
        Comment = "This license is a variant of HPND (https://spdx.org/licenses/HPND.html). This variant explicitly includes the permission to \"sell\" the software, which is not explicitly referenced in the HPND template, and makes a few other minor changes. It otherwise retains the optional templated formatting from HPND.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LPL_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/LPL-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/LPL-1.0")
        ],
        LicenseText = ReadResource("LPL-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("LPL-1.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense NLOD_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/NLOD-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://data.norge.no/nlod/en/1.0")
        ],
        LicenseText = ReadResource("NLOD-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("NLOD-1.0.template.txt"),
        Comment = "Norwegian translation available here: http://data.norge.no/nlod/no/1.0",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense POSTGRESQL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/PostgreSQL"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.postgresql.org/about/licence"),
            new Uri("https://opensource.org/licenses/PostgreSQL")
        ],
        LicenseText = ReadResource("PostgreSQL.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("PostgreSQL.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense PHP_3_01 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/PHP-3.01"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.php.net/license/3_01.txt")
        ],
        LicenseText = ReadResource("PHP-3.01.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("PHP-3.01.template.txt"),
        Comment = "The PHP License v3.01 is essentially the same as v3.0, with the exception of a couple word differences and updated url in section 6.",
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense UNLICENSE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Unlicense"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://unlicense.org/")
        ],
        LicenseText = ReadResource("Unlicense.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Unlicense.template.txt"),
        Comment = "This is a public domain dedication",
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense TU_BERLIN_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/TU-Berlin-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/CorsixTH/deps/blob/fd339a9f526d1d9c9f01ccf39e438a015da50035/licences/libgsm.txt")
        ],
        LicenseText = ReadResource("TU-Berlin-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("TU-Berlin-2.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense XKEYBOARD_CONFIG_ZINOVIEV = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/xkeyboard-config-Zinoviev"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://gitlab.freedesktop.org/xkeyboard-config/xkeyboard-config/-/blob/master/COPYING?ref_type=heads#L178")
        ],
        LicenseText = ReadResource("xkeyboard-config-Zinoviev.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("xkeyboard-config-Zinoviev.template.txt"),
        Comment = "The first section of this license is the same as Cronx, but it adds a second part and short warranty disclaimer.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense ULEM = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/ulem"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://mirrors.ctan.org/macros/latex/contrib/ulem/README")
        ],
        LicenseText = ReadResource("ulem.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("ulem.template.txt"),
        Comment = "This license is a very similar to fwlw and magaz, but has slightly different obligations.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense HPND_MERCHANTABILITY_VARIANT = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/HPND-merchantability-variant"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://sourceware.org/git/?p=newlib-cygwin.git;a=blob;f=newlib/libc/misc/fini.c;hb=HEAD")
        ],
        LicenseText = ReadResource("HPND-merchantability-variant.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("HPND-merchantability-variant.template.txt"),
        Comment = "This is similar to the HPND grant and short disclaimer, but adds a specific disclaimer as to merchantability and fitness for a particular purpose.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GFDL_1_3_OR_LATER = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GFDL-1.3-or-later"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/fdl-1.3.txt")
        ],
        LicenseText = ReadResource("GFDL-1.3-or-later.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GFDL-1.3-or-later.template.txt"),
        StandardLicenseHeader = ReadResource("GFDL-1.3-or-later.header.txt"),
        Comment = "This license was released 3 November 2008. The identifier GFDL-1.3-or-later can be used to indicate that this license applies, without asserting whether or not any Invariant Sections, Front-Cover Texts or Back-Cover Texts are present. See GFDL-1.3-or-later-invariants and GFDL-1.3-or-later-no-invariants for alternative identifiers that can be used to express explicitly that these sections or cover texts are present or are not present, respectively.",
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GPL_3_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GPL-3.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/gpl-3.0-standalone.html"),
            new Uri("https://opensource.org/licenses/GPL-3.0")
        ],
        LicenseText = ReadResource("GPL-3.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GPL-3.0.template.txt"),
        StandardLicenseHeader = ReadResource("GPL-3.0.header.txt"),
        IsFsfLibre = true,
        IsOsiApproved = true,
        IsDeprecatedLicenseId = true,
        DeprecatedVersion = "3.0",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BSD_2_CLAUSE_DARWIN = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/BSD-2-Clause-Darwin"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/file/file/blob/master/COPYING")
        ],
        LicenseText = ReadResource("BSD-2-Clause-Darwin.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("BSD-2-Clause-Darwin.template.txt"),
        Comment = "This is similar to BSD-2-Clause, except it adds \"immediately at the beginning of the file, without modification\" in the first clause and adds an attempt to disclaim export law in the beginning.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OGL_UK_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OGL-UK-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.nationalarchives.gov.uk/doc/open-government-licence/version/2/")
        ],
        LicenseText = ReadResource("OGL-UK-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OGL-UK-2.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GFDL_1_2_INVARIANTS_ONLY = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GFDL-1.2-invariants-only"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/old-licenses/fdl-1.2.txt")
        ],
        LicenseText = ReadResource("GFDL-1.2-invariants-only.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GFDL-1.2-invariants-only.template.txt"),
        StandardLicenseHeader = ReadResource("GFDL-1.2-invariants-only.header.txt"),
        Comment = "This license was released November 2002. The identifier GFDL-1.2-only-invariants should only be used when there are Invariant Sections, Front-Cover Texts or Back-Cover Texts. See GFDL-1.2-only and GFDL-1.2-only-no-invariants for alternatives.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_NC_ND_3_0_DE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-NC-ND-3.0-DE"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by-nc-nd/3.0/de/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-NC-ND-3.0-DE.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-NC-ND-3.0-DE.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CPL_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CPL-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/CPL-1.0")
        ],
        LicenseText = ReadResource("CPL-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CPL-1.0.template.txt"),
        Comment = "This license was superseded by Eclipse Public License",
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense MULANPSL_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/MulanPSL-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://license.coscl.org.cn/MulanPSL/"),
            new Uri("https://github.com/yuwenlong/longphp/blob/25dfb70cc2a466dc4bb55ba30901cbce08d164b5/LICENSE")
        ],
        LicenseText = ReadResource("MulanPSL-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("MulanPSL-1.0.template.txt"),
        StandardLicenseHeader = ReadResource("MulanPSL-1.0.header.txt"),
        Comment = "Both the Chinese and English translations of this license have been included in the markup, because current examples of use appear to include both translations in license documents.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_SA_3_0_DE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-SA-3.0-DE"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by-sa/3.0/de/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-SA-3.0-DE.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-SA-3.0-DE.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense EFL_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/EFL-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.eiffel-nice.org/license/forum.txt"),
            new Uri("https://opensource.org/licenses/EFL-1.0")
        ],
        LicenseText = ReadResource("EFL-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("EFL-1.0.template.txt"),
        Comment = "This license has been superseded by v2.0",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GPL_2_0_ = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GPL-2.0+"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/old-licenses/gpl-2.0-standalone.html"),
            new Uri("https://opensource.org/licenses/GPL-2.0")
        ],
        LicenseText = ReadResource("GPL-2.0+.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GPL-2.0+.template.txt"),
        StandardLicenseHeader = ReadResource("GPL-2.0+.header.txt"),
        IsFsfLibre = true,
        IsOsiApproved = true,
        IsDeprecatedLicenseId = true,
        DeprecatedVersion = "2.0rc2",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense MIT_CLICK = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/MIT-Click"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/kohler/t1utils/blob/master/LICENSE")
        ],
        LicenseText = ReadResource("MIT-Click.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("MIT-Click.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense HIPPOCRATIC_2_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Hippocratic-2.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://firstdonoharm.dev/version/2/1/license.html"),
            new Uri("https://github.com/EthicalSource/hippocratic-license/blob/58c0e646d64ff6fbee275bfe2b9492f914e3ab2a/LICENSE.txt")
        ],
        LicenseText = ReadResource("Hippocratic-2.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Hippocratic-2.1.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GFDL_1_2_INVARIANTS_OR_LATER = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GFDL-1.2-invariants-or-later"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/old-licenses/fdl-1.2.txt")
        ],
        LicenseText = ReadResource("GFDL-1.2-invariants-or-later.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GFDL-1.2-invariants-or-later.template.txt"),
        StandardLicenseHeader = ReadResource("GFDL-1.2-invariants-or-later.header.txt"),
        Comment = "This license was released November 2002. The identifier GFDL-1.2-or-later-invariants should only be used when there are Invariant Sections, Front-Cover Texts or Back-Cover Texts. See GFDL-1.2-or-later and GFDL-1.2-or-later-no-invariants for alternatives.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OPL_UK_3_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OPL-UK-3.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.parliament.uk/site-information/copyright-parliament/open-parliament-licence/")
        ],
        LicenseText = ReadResource("OPL-UK-3.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OPL-UK-3.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense RUBY_PTY = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Ruby-pty"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/ruby/ruby/blob/9f6deaa6888a423720b4b127b5314f0ad26cc2e6/ext/pty/pty.c#L775-L786"),
            new Uri("https://github.com/ruby/ruby/commit/0a64817fb80016030c03518fb9459f63c11605ea#diff-ef5fa30838d6d0cecad9e675cc50b24628cfe2cb277c346053fafcc36c91c204"),
            new Uri("https://github.com/ruby/ruby/commit/0a64817fb80016030c03518fb9459f63c11605ea#diff-fedf217c1ce44bda01f0a678d3ff8b198bed478754d699c527a698ad933979a0")
        ],
        LicenseText = ReadResource("Ruby-pty.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Ruby-pty.template.txt"),
        Comment = "There is a Japanese translation of this license included with some instances of use.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_3_0_DE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-3.0-DE"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by/3.0/de/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-3.0-DE.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-3.0-DE.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense FWLW = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/fwlw"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://mirrors.nic.cz/tex-archive/macros/latex/contrib/fwlw/README")
        ],
        LicenseText = ReadResource("fwlw.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("fwlw.template.txt"),
        Comment = "This license is a very similar to ulem and magaz, but has slightly different obligations.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense MIT_FEH = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/MIT-feh"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/MIT#feh")
        ],
        LicenseText = ReadResource("MIT-feh.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("MIT-feh.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GPL_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GPL-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/old-licenses/gpl-1.0-standalone.html")
        ],
        LicenseText = ReadResource("GPL-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GPL-1.0.template.txt"),
        StandardLicenseHeader = ReadResource("GPL-1.0.header.txt"),
        IsDeprecatedLicenseId = true,
        DeprecatedVersion = "3.0",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense APAFML = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/APAFML"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/AdobePostscriptAFM")
        ],
        LicenseText = ReadResource("APAFML.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("APAFML.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense AMPAS = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/AMPAS"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/BSD#AMPASBSD")
        ],
        LicenseText = ReadResource("AMPAS.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("AMPAS.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense NOKIA = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Nokia"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/nokia")
        ],
        LicenseText = ReadResource("Nokia.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Nokia.template.txt"),
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense DIFFMARK = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/diffmark"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/diffmark")
        ],
        LicenseText = ReadResource("diffmark.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("diffmark.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OLDAP_2_2_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OLDAP-2.2.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.openldap.org/devel/gitweb.cgi?p=openldap.git;a=blob;f=LICENSE;hb=4bc786f34b50aa301be6f5600f58a980070f481e")
        ],
        LicenseText = ReadResource("OLDAP-2.2.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OLDAP-2.2.1.template.txt"),
        Comment = "This license was released 1 March 2000.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_BY_NC_SA_2_0_DE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-BY-NC-SA-2.0-DE"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/by-nc-sa/2.0/de/legalcode")
        ],
        LicenseText = ReadResource("CC-BY-NC-SA-2.0-DE.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-BY-NC-SA-2.0-DE.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense TPDL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/TPDL"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://metacpan.org/pod/Time::ParseDate#LICENSE")
        ],
        LicenseText = ReadResource("TPDL.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("TPDL.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense THREEPARTTABLE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/threeparttable"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/Threeparttable")
        ],
        LicenseText = ReadResource("threeparttable.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("threeparttable.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense RHECOS_1_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/RHeCos-1.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://ecos.sourceware.org/old-license.html")
        ],
        LicenseText = ReadResource("RHeCos-1.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("RHeCos-1.1.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OCCT_PL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OCCT-PL"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.opencascade.com/content/occt-public-license")
        ],
        LicenseText = ReadResource("OCCT-PL.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OCCT-PL.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense HASKELLREPORT = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/HaskellReport"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/Haskell_Language_Report_License")
        ],
        LicenseText = ReadResource("HaskellReport.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("HaskellReport.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GPL_2_0_WITH_GCC_EXCEPTION = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GPL-2.0-with-GCC-exception"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://gcc.gnu.org/git/?p=gcc.git;a=blob;f=gcc/libgcc1.c;h=762f5143fc6eed57b6797c82710f3538aa52b40b;hb=cb143a3ce4fb417c68f5fa2691a1b1b1053dfba9#l10")
        ],
        LicenseText = ReadResource("GPL-2.0-with-GCC-exception.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GPL-2.0-with-GCC-exception.template.txt"),
        Comment = "DEPRECATED: Use license expression including main license, \"WITH\" operator, and identifier: GCC-exception-2.0",
        IsDeprecatedLicenseId = true,
        DeprecatedVersion = "2.0rc2",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense PADL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/PADL"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://git.openldap.org/openldap/openldap/-/blob/master/libraries/libldap/os-local.c?ref_type=heads#L19-23")
        ],
        LicenseText = ReadResource("PADL.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("PADL.template.txt"),
        Comment = "This is similar to BSD-4.3RENO and Furuseth",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense NASA_1_3 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/NASA-1.3"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://ti.arc.nasa.gov/opensource/nosa/"),
            new Uri("https://opensource.org/licenses/NASA-1.3")
        ],
        LicenseText = ReadResource("NASA-1.3.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("NASA-1.3.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense LGPL_3_0_ = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/LGPL-3.0+"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/lgpl-3.0-standalone.html"),
            new Uri("https://www.gnu.org/licenses/lgpl+gpl-3.0.txt"),
            new Uri("https://opensource.org/licenses/LGPL-3.0")
        ],
        LicenseText = ReadResource("LGPL-3.0+.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("LGPL-3.0+.template.txt"),
        Comment = "The identifier \"LGPL-3.0+\" has been deprecated; LGPL-3.0-or-later is the preferred identifier to indicate version 3.0 or any later version of the LGPL.",
        IsFsfLibre = true,
        IsOsiApproved = true,
        IsDeprecatedLicenseId = true,
        DeprecatedVersion = "2.0rc2",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CC_SA_1_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CC-SA-1.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://creativecommons.org/licenses/sa/1.0/legalcode")
        ],
        LicenseText = ReadResource("CC-SA-1.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CC-SA-1.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GNUPLOT = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/gnuplot"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/Gnuplot")
        ],
        LicenseText = ReadResource("gnuplot.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("gnuplot.template.txt"),
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense RPL_1_5 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/RPL-1.5"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://opensource.org/licenses/RPL-1.5")
        ],
        LicenseText = ReadResource("RPL-1.5.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("RPL-1.5.template.txt"),
        Comment = "This license was released: 15 July 2007",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense JPL_IMAGE = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/JPL-image"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.jpl.nasa.gov/jpl-image-use-policy")
        ],
        LicenseText = ReadResource("JPL-image.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("JPL-image.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense CERN_OHL_W_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/CERN-OHL-W-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.ohwr.org/project/cernohl/wikis/Documents/CERN-OHL-version-2")
        ],
        LicenseText = ReadResource("CERN-OHL-W-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("CERN-OHL-W-2.0.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense JAM = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Jam"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.boost.org/doc/libs/1_35_0/doc/html/jam.html"),
            new Uri("https://web.archive.org/web/20160330173339/https://swarm.workshop.perforce.com/files/guest/perforce_software/jam/src/README")
        ],
        LicenseText = ReadResource("Jam.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Jam.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense BSD_3_CLAUSE_NO_NUCLEAR_WARRANTY = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/BSD-3-Clause-No-Nuclear-Warranty"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://jogamp.org/git/?p=gluegen.git;a=blob_plain;f=LICENSE.txt")
        ],
        LicenseText = ReadResource("BSD-3-Clause-No-Nuclear-Warranty.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("BSD-3-Clause-No-Nuclear-Warranty.template.txt"),
        Comment = "This license has a Sun copyright notice. It is the same license as BSD-3-Clause-No-Nuclear-License, except it has a disclaimer for nuclear facility use, instead of the software \"not licensed\" for such use.",
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense TRUSTEDQSL = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/TrustedQSL"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://sourceforge.net/p/trustedqsl/tqsl/ci/master/tree/LICENSE.txt")
        ],
        LicenseText = ReadResource("TrustedQSL.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("TrustedQSL.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense OSL_1_1 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/OSL-1.1"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://fedoraproject.org/wiki/Licensing/OSL1.1")
        ],
        LicenseText = ReadResource("OSL-1.1.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("OSL-1.1.template.txt"),
        StandardLicenseHeader = ReadResource("OSL-1.1.header.txt"),
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense AGPL_1_0_ONLY = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/AGPL-1.0-only"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://www.affero.org/oagpl.html")
        ],
        LicenseText = ReadResource("AGPL-1.0-only.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("AGPL-1.0-only.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense MARTIN_BIRGMEIER = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/Martin-Birgmeier"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://github.com/Perl/perl5/blob/blead/util.c#L6136")
        ],
        LicenseText = ReadResource("Martin-Birgmeier.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("Martin-Birgmeier.template.txt"),
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense GPL_2_0_ONLY = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/GPL-2.0-only"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("https://www.gnu.org/licenses/old-licenses/gpl-2.0-standalone.html"),
            new Uri("https://www.gnu.org/licenses/old-licenses/gpl-2.0.txt"),
            new Uri("https://opensource.org/licenses/GPL-2.0")
        ],
        LicenseText = ReadResource("GPL-2.0-only.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("GPL-2.0-only.template.txt"),
        StandardLicenseHeader = ReadResource("GPL-2.0-only.header.txt"),
        Comment = "This license was released: June 1991. This license identifier refers to the choice to use the code under GPL-2.0-only, as distinguished from the use of code under GPL-2.0-or-later (i.e., GPL-2.0 or some later version). The license notice (as seen in the Standard License Header field below) states which of these applies to the code in the file. The example in the How to Apply These Terms appendix of the license shows the \"or later\" approach.",
        IsFsfLibre = true,
        IsOsiApproved = true,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };
 
    public static readonly ListedLicense SGI_B_2_0 = new ListedLicense
    {
        SpdxId = new Uri("http://spdx.org/licenses/SGI-B-2.0"),
        Type = "expandedlicensing_ListedLicense",
        SeeAlso = [ 
            new Uri("http://oss.sgi.com/projects/FreeB/SGIFreeSWLicB.2.0.pdf")
        ],
        LicenseText = ReadResource("SGI-B-2.0.fulltext.txt"),  
        StandardLicenseTemplate = ReadResource("SGI-B-2.0.template.txt"),
        Comment = "This license was released 18 Sept 2008",
        IsFsfLibre = true,
        IsOsiApproved = false,
        
        Catalog = _creationInfo.Catalog,
        CreationInfo = _creationInfo,
    };


    public readonly static Dictionary<string, ListedLicense> Licenses = new Dictionary<string, ListedLicense>
    { 
        { "BSD-Source-beginning-file", BSD_SOURCE_BEGINNING_FILE },
        { "BSD-3-Clause-No-Nuclear-License-2014", BSD_3_CLAUSE_NO_NUCLEAR_LICENSE_2014 },
        { "GD", GD },
        { "CC-BY-NC-4.0", CC_BY_NC_4_0 },
        { "NICTA-1.0", NICTA_1_0 },
        { "MS-RL", MS_RL },
        { "metamail", METAMAIL },
        { "FSFULLR", FSFULLR },
        { "OSET-PL-2.1", OSET_PL_2_1 },
        { "Pixar", PIXAR },
        { "Wsuipa", WSUIPA },
        { "Unlicense-libtelnet", UNLICENSE_LIBTELNET },
        { "Soundex", SOUNDEX },
        { "libselinux-1.0", LIBSELINUX_1_0 },
        { "CDDL-1.0", CDDL_1_0 },
        { "OLDAP-2.2", OLDAP_2_2 },
        { "Intel", INTEL },
        { "PolyForm-Noncommercial-1.0.0", POLYFORM_NONCOMMERCIAL_1_0_0 },
        { "TTWL", TTWL },
        { "UnixCrypt", UNIXCRYPT },
        { "HPND-doc-sell", HPND_DOC_SELL },
        { "UMich-Merit", UMICH_MERIT },
        { "Naumen", NAUMEN },
        { "CrystalStacker", CRYSTALSTACKER },
        { "LGPL-2.0-only", LGPL_2_0_ONLY },
        { "BSD-3-Clause-LBNL", BSD_3_CLAUSE_LBNL },
        { "mpich2", MPICH2 },
        { "CC-BY-NC-SA-2.0", CC_BY_NC_SA_2_0 },
        { "GPL-2.0", GPL_2_0 },
        { "OLFL-1.3", OLFL_1_3 },
        { "iMatix", IMATIX },
        { "APSL-1.1", APSL_1_1 },
        { "Minpack", MINPACK },
        { "Leptonica", LEPTONICA },
        { "LGPL-2.0-or-later", LGPL_2_0_OR_LATER },
        { "BSD-3-Clause-Attribution", BSD_3_CLAUSE_ATTRIBUTION },
        { "HPND-export-US-modify", HPND_EXPORT_US_MODIFY },
        { "CC-BY-ND-3.0-DE", CC_BY_ND_3_0_DE },
        { "ZPL-1.1", ZPL_1_1 },
        { "VOSTROM", VOSTROM },
        { "python-ldap", PYTHON_LDAP },
        { "Apache-1.0", APACHE_1_0 },
        { "IEC-Code-Components-EULA", IEC_CODE_COMPONENTS_EULA },
        { "Nunit", NUNIT },
        { "EUPL-1.2", EUPL_1_2 },
        { "0BSD", _0BSD },
        { "Brian-Gladman-2-Clause", BRIAN_GLADMAN_2_CLAUSE },
        { "OGTSL", OGTSL },
        { "CUA-OPL-1.0", CUA_OPL_1_0 },
        { "Latex2e-translated-notice", LATEX2E_TRANSLATED_NOTICE },
        { "Furuseth", FURUSETH },
        { "SSH-short", SSH_SHORT },
        { "TGPPL-1.0", TGPPL_1_0 },
        { "AGPL-3.0-or-later", AGPL_3_0_OR_LATER },
        { "CC-BY-NC-2.5", CC_BY_NC_2_5 },
        { "LGPL-3.0", LGPL_3_0 },
        { "NIST-Software", NIST_SOFTWARE },
        { "BSD-2-Clause", BSD_2_CLAUSE },
        { "BSD-3-Clause-No-Military-License", BSD_3_CLAUSE_NO_MILITARY_LICENSE },
        { "NLPL", NLPL },
        { "PolyForm-Small-Business-1.0.0", POLYFORM_SMALL_BUSINESS_1_0_0 },
        { "Knuth-CTAN", KNUTH_CTAN },
        { "OLDAP-2.0.1", OLDAP_2_0_1 },
        { "AGPL-3.0-only", AGPL_3_0_ONLY },
        { "Game-Programming-Gems", GAME_PROGRAMMING_GEMS },
        { "BSD-3-Clause", BSD_3_CLAUSE },
        { "NAIST-2003", NAIST_2003 },
        { "CERN-OHL-1.2", CERN_OHL_1_2 },
        { "CC-BY-NC-SA-2.0-FR", CC_BY_NC_SA_2_0_FR },
        { "Artistic-dist", ARTISTIC_DIST },
        { "NBPL-1.0", NBPL_1_0 },
        { "Caldera", CALDERA },
        { "MIT-open-group", MIT_OPEN_GROUP },
        { "Bitstream-Charter", BITSTREAM_CHARTER },
        { "CERN-OHL-S-2.0", CERN_OHL_S_2_0 },
        { "W3C-20150513", W3C_20150513 },
        { "EPL-1.0", EPL_1_0 },
        { "QPL-1.0", QPL_1_0 },
        { "FSFAP-no-warranty-disclaimer", FSFAP_NO_WARRANTY_DISCLAIMER },
        { "CC-BY-NC-ND-1.0", CC_BY_NC_ND_1_0 },
        { "ASWF-Digital-Assets-1.0", ASWF_DIGITAL_ASSETS_1_0 },
        { "bcrypt-Solar-Designer", BCRYPT_SOLAR_DESIGNER },
        { "YPL-1.1", YPL_1_1 },
        { "Frameworx-1.0", FRAMEWORX_1_0 },
        { "BitTorrent-1.1", BITTORRENT_1_1 },
        { "curl", CURL },
        { "GFDL-1.1", GFDL_1_1 },
        { "MPL-1.1", MPL_1_1 },
        { "LZMA-SDK-9.11-to-9.20", LZMA_SDK_9_11_TO_9_20 },
        { "WTFPL", WTFPL },
        { "FTL", FTL },
        { "CC-BY-NC-ND-3.0-IGO", CC_BY_NC_ND_3_0_IGO },
        { "Cronyx", CRONYX },
        { "HPND-Intel", HPND_INTEL },
        { "FreeBSD-DOC", FREEBSD_DOC },
        { "Abstyles", ABSTYLES },
        { "HPND-doc", HPND_DOC },
        { "libpng-2.0", LIBPNG_2_0 },
        { "HPND-Netrek", HPND_NETREK },
        { "Xnet", XNET },
        { "OGL-Canada-2.0", OGL_CANADA_2_0 },
        { "Mackerras-3-Clause", MACKERRAS_3_CLAUSE },
        { "BSD-Advertising-Acknowledgement", BSD_ADVERTISING_ACKNOWLEDGEMENT },
        { "EUDatagrid", EUDATAGRID },
        { "AML", AML },
        { "Sun-PPP", SUN_PPP },
        { "CERN-OHL-1.1", CERN_OHL_1_1 },
        { "CC-BY-NC-ND-4.0", CC_BY_NC_ND_4_0 },
        { "xlock", XLOCK },
        { "snprintf", SNPRINTF },
        { "OFL-1.0", OFL_1_0 },
        { "FSFAP", FSFAP },
        { "W3C-19980720", W3C_19980720 },
        { "CC-BY-3.0-AU", CC_BY_3_0_AU },
        { "CC-BY-SA-2.5", CC_BY_SA_2_5 },
        { "GFDL-1.1-no-invariants-or-later", GFDL_1_1_NO_INVARIANTS_OR_LATER },
        { "MirOS", MIROS },
        { "OFL-1.0-no-RFN", OFL_1_0_NO_RFN },
        { "HPND-sell-variant-MIT-disclaimer-rev", HPND_SELL_VARIANT_MIT_DISCLAIMER_REV },
        { "Ferguson-Twofish", FERGUSON_TWOFISH },
        { "GPL-2.0-with-bison-exception", GPL_2_0_WITH_BISON_EXCEPTION },
        { "GFDL-1.1-no-invariants-only", GFDL_1_1_NO_INVARIANTS_ONLY },
        { "ECL-2.0", ECL_2_0 },
        { "Motosoto", MOTOSOTO },
        { "DocBook-Stylesheet", DOCBOOK_STYLESHEET },
        { "CC-BY-NC-3.0", CC_BY_NC_3_0 },
        { "OPL-1.0", OPL_1_0 },
        { "Linux-man-pages-copyleft", LINUX_MAN_PAGES_COPYLEFT },
        { "SHL-0.51", SHL_0_51 },
        { "CC-BY-NC-ND-2.0", CC_BY_NC_ND_2_0 },
        { "Sendmail-Open-Source-1.1", SENDMAIL_OPEN_SOURCE_1_1 },
        { "CC-BY-NC-3.0-DE", CC_BY_NC_3_0_DE },
        { "NPL-1.1", NPL_1_1 },
        { "radvd", RADVD },
        { "BSD-2-Clause-Patent", BSD_2_CLAUSE_PATENT },
        { "NTP-0", NTP_0 },
        { "Artistic-1.0-cl8", ARTISTIC_1_0_CL8 },
        { "BSD-2-Clause-FreeBSD", BSD_2_CLAUSE_FREEBSD },
        { "CAL-1.0", CAL_1_0 },
        { "BSD-Protection", BSD_PROTECTION },
        { "HPND", HPND },
        { "Boehm-GC-without-fee", BOEHM_GC_WITHOUT_FEE },
        { "TCP-wrappers", TCP_WRAPPERS },
        { "TORQUE-1.1", TORQUE_1_1 },
        { "OSL-3.0", OSL_3_0 },
        { "Unicode-3.0", UNICODE_3_0 },
        { "NPL-1.0", NPL_1_0 },
        { "Symlinks", SYMLINKS },
        { "CC-BY-SA-2.1-JP", CC_BY_SA_2_1_JP },
        { "MIT-Modern-Variant", MIT_MODERN_VARIANT },
        { "GFDL-1.3-invariants-or-later", GFDL_1_3_INVARIANTS_OR_LATER },
        { "Arphic-1999", ARPHIC_1999 },
        { "NPOSL-3.0", NPOSL_3_0 },
        { "CC-BY-SA-3.0-AT", CC_BY_SA_3_0_AT },
        { "MPL-1.0", MPL_1_0 },
        { "LGPL-3.0-only", LGPL_3_0_ONLY },
        { "OLDAP-2.5", OLDAP_2_5 },
        { "OAR", OAR },
        { "SSH-OpenSSH", SSH_OPENSSH },
        { "Glulxe", GLULXE },
        { "MIT-Wu", MIT_WU },
        { "BSD-4-Clause-Shortened", BSD_4_CLAUSE_SHORTENED },
        { "Unicode-TOU", UNICODE_TOU },
        { "Elastic-2.0", ELASTIC_2_0 },
        { "CC-BY-SA-3.0", CC_BY_SA_3_0 },
        { "LGPL-2.1", LGPL_2_1 },
        { "ZPL-2.0", ZPL_2_0 },
        { "LPPL-1.0", LPPL_1_0 },
        { "BitTorrent-1.0", BITTORRENT_1_0 },
        { "OGC-1.0", OGC_1_0 },
        { "any-OSI-perl-modules", ANY_OSI_PERL_MODULES },
        { "BSD-Systemics-W3Works", BSD_SYSTEMICS_W3WORKS },
        { "IPL-1.0", IPL_1_0 },
        { "CC-BY-NC-ND-2.5", CC_BY_NC_ND_2_5 },
        { "GPL-2.0-with-font-exception", GPL_2_0_WITH_FONT_EXCEPTION },
        { "Community-Spec-1.0", COMMUNITY_SPEC_1_0 },
        { "Sendmail", SENDMAIL },
        { "HTMLTIDY", HTMLTIDY },
        { "CNRI-Jython", CNRI_JYTHON },
        { "Beerware", BEERWARE },
        { "BSD-3-Clause-Open-MPI", BSD_3_CLAUSE_OPEN_MPI },
        { "UCAR", UCAR },
        { "Gutmann", GUTMANN },
        { "OLDAP-1.3", OLDAP_1_3 },
        { "Graphics-Gems", GRAPHICS_GEMS },
        { "OGDL-Taiwan-1.0", OGDL_TAIWAN_1_0 },
        { "LiLiQ-P-1.1", LILIQ_P_1_1 },
        { "SISSL", SISSL },
        { "NRL", NRL },
        { "McPhee-slideshow", MCPHEE_SLIDESHOW },
        { "UPL-1.0", UPL_1_0 },
        { "Xerox", XEROX },
        { "TPL-1.0", TPL_1_0 },
        { "Zed", ZED },
        { "UCL-1.0", UCL_1_0 },
        { "ADSL", ADSL },
        { "IJG", IJG },
        { "SAX-PD", SAX_PD },
        { "AGPL-1.0", AGPL_1_0 },
        { "SchemeReport", SCHEMEREPORT },
        { "PHP-3.0", PHP_3_0 },
        { "LGPLLR", LGPLLR },
        { "TMate", TMATE },
        { "CDLA-Sharing-1.0", CDLA_SHARING_1_0 },
        { "HPND-Pbmplus", HPND_PBMPLUS },
        { "DocBook-Schema", DOCBOOK_SCHEMA },
        { "GFDL-1.2", GFDL_1_2 },
        { "CC-BY-NC-SA-1.0", CC_BY_NC_SA_1_0 },
        { "Sun-PPP-2000", SUN_PPP_2000 },
        { "GFDL-1.3-invariants-only", GFDL_1_3_INVARIANTS_ONLY },
        { "AFL-3.0", AFL_3_0 },
        { "YPL-1.0", YPL_1_0 },
        { "ISC", ISC },
        { "Caldera-no-preamble", CALDERA_NO_PREAMBLE },
        { "OLDAP-2.8", OLDAP_2_8 },
        { "Linux-OpenIB", LINUX_OPENIB },
        { "AGPL-1.0-or-later", AGPL_1_0_OR_LATER },
        { "pkgconf", PKGCONF },
        { "GPL-3.0+", GPL_3_0_ },
        { "OpenPBS-2.3", OPENPBS_2_3 },
        { "Crossword", CROSSWORD },
        { "NTIA-PD", NTIA_PD },
        { "LAL-1.3", LAL_1_3 },
        { "HPND-MIT-disclaimer", HPND_MIT_DISCLAIMER },
        { "AMD-newlib", AMD_NEWLIB },
        { "CNRI-Python", CNRI_PYTHON },
        { "LPD-document", LPD_DOCUMENT },
        { "QPL-1.0-INRIA-2004", QPL_1_0_INRIA_2004 },
        { "Spencer-86", SPENCER_86 },
        { "Apache-1.1", APACHE_1_1 },
        { "HPND-UC", HPND_UC },
        { "Net-SNMP", NET_SNMP },
        { "hdparm", HDPARM },
        { "Multics", MULTICS },
        { "APSL-1.2", APSL_1_2 },
        { "dtoa", DTOA },
        { "gSOAP-1.3b", GSOAP_1_3B },
        { "SGI-B-1.0", SGI_B_1_0 },
        { "AGPL-3.0", AGPL_3_0 },
        { "GL2PS", GL2PS },
        { "Cube", CUBE },
        { "HPND-export-US", HPND_EXPORT_US },
        { "SNIA", SNIA },
        { "GPL-2.0-with-classpath-exception", GPL_2_0_WITH_CLASSPATH_EXCEPTION },
        { "JasPer-2.0", JASPER_2_0 },
        { "Apache-2.0", APACHE_2_0 },
        { "TTYP0", TTYP0 },
        { "SL", SL },
        { "LPPL-1.3a", LPPL_1_3A },
        { "AFL-1.1", AFL_1_1 },
        { "OpenVision", OPENVISION },
        { "LGPL-2.1-only", LGPL_2_1_ONLY },
        { "ODC-By-1.0", ODC_BY_1_0 },
        { "APSL-2.0", APSL_2_0 },
        { "CC-BY-NC-SA-3.0-IGO", CC_BY_NC_SA_3_0_IGO },
        { "FSFULLRWD", FSFULLRWD },
        { "SGP4", SGP4 },
        { "wxWindows", WXWINDOWS },
        { "CC-BY-SA-2.0-UK", CC_BY_SA_2_0_UK },
        { "OLDAP-2.1", OLDAP_2_1 },
        { "Lucida-Bitmap-Fonts", LUCIDA_BITMAP_FONTS },
        { "LGPL-2.0+", LGPL_2_0_ },
        { "Entessa", ENTESSA },
        { "BSD-3-Clause-acpica", BSD_3_CLAUSE_ACPICA },
        { "NIST-PD-fallback", NIST_PD_FALLBACK },
        { "OFL-1.1", OFL_1_1 },
        { "CECILL-2.0", CECILL_2_0 },
        { "TU-Berlin-1.0", TU_BERLIN_1_0 },
        { "MPL-2.0", MPL_2_0 },
        { "HPND-Fenneberg-Livingston", HPND_FENNEBERG_LIVINGSTON },
        { "OFL-1.1-no-RFN", OFL_1_1_NO_RFN },
        { "NCL", NCL },
        { "Xdebug-1.03", XDEBUG_1_03 },
        { "D-FSL-1.0", D_FSL_1_0 },
        { "OLDAP-1.2", OLDAP_1_2 },
        { "ICU", ICU },
        { "GPL-3.0-or-later", GPL_3_0_OR_LATER },
        { "URT-RLE", URT_RLE },
        { "LOOP", LOOP },
        { "OPUBL-1.0", OPUBL_1_0 },
        { "GCR-docs", GCR_DOCS },
        { "mplus", MPLUS },
        { "GFDL-1.2-only", GFDL_1_2_ONLY },
        { "HP-1989", HP_1989 },
        { "OpenSSL", OPENSSL },
        { "SunPro", SUNPRO },
        { "softSurfer", SOFTSURFER },
        { "Barr", BARR },
        { "HPND-export2-US", HPND_EXPORT2_US },
        { "GFDL-1.1-invariants-only", GFDL_1_1_INVARIANTS_ONLY },
        { "BSD-3-Clause-Modification", BSD_3_CLAUSE_MODIFICATION },
        { "MIT-testregex", MIT_TESTREGEX },
        { "Artistic-2.0", ARTISTIC_2_0 },
        { "cve-tou", CVE_TOU },
        { "pnmstitch", PNMSTITCH },
        { "OLDAP-1.4", OLDAP_1_4 },
        { "OFL-1.0-RFN", OFL_1_0_RFN },
        { "BSD-1-Clause", BSD_1_CLAUSE },
        { "lsof", LSOF },
        { "NTP", NTP },
        { "AMDPLPA", AMDPLPA },
        { "Python-2.0", PYTHON_2_0 },
        { "Baekmuk", BAEKMUK },
        { "SSPL-1.0", SSPL_1_0 },
        { "Giftware", GIFTWARE },
        { "Kazlib", KAZLIB },
        { "Zend-2.0", ZEND_2_0 },
        { "jove", JOVE },
        { "check-cvs", CHECK_CVS },
        { "DSDP", DSDP },
        { "GFDL-1.1-invariants-or-later", GFDL_1_1_INVARIANTS_OR_LATER },
        { "RSCPL", RSCPL },
        { "PPL", PPL },
        { "swrule", SWRULE },
        { "SSLeay-standalone", SSLEAY_STANDALONE },
        { "OSL-2.0", OSL_2_0 },
        { "Ubuntu-font-1.0", UBUNTU_FONT_1_0 },
        { "GFDL-1.1-only", GFDL_1_1_ONLY },
        { "SPL-1.0", SPL_1_0 },
        { "MS-LPL", MS_LPL },
        { "Ruby", RUBY },
        { "GFDL-1.3", GFDL_1_3 },
        { "VSL-1.0", VSL_1_0 },
        { "Unicode-DFS-2015", UNICODE_DFS_2015 },
        { "ANTLR-PD-fallback", ANTLR_PD_FALLBACK },
        { "OLDAP-1.1", OLDAP_1_1 },
        { "X11", X11 },
        { "blessing", BLESSING },
        { "BSD-4.3TAHOE", BSD_4_3TAHOE },
        { "Clips", CLIPS },
        { "Bahyph", BAHYPH },
        { "EFL-2.0", EFL_2_0 },
        { "BSD-4-Clause", BSD_4_CLAUSE },
        { "RPSL-1.0", RPSL_1_0 },
        { "Eurosym", EUROSYM },
        { "GPL-1.0+", GPL_1_0_ },
        { "Condor-1.1", CONDOR_1_1 },
        { "Unicode-DFS-2016", UNICODE_DFS_2016 },
        { "CC-BY-2.5-AU", CC_BY_2_5_AU },
        { "CECILL-B", CECILL_B },
        { "MPL-2.0-no-copyleft-exception", MPL_2_0_NO_COPYLEFT_EXCEPTION },
        { "SGI-OpenGL", SGI_OPENGL },
        { "FSFUL", FSFUL },
        { "Adobe-Utopia", ADOBE_UTOPIA },
        { "CERN-OHL-P-2.0", CERN_OHL_P_2_0 },
        { "FSL-1.1-ALv2", FSL_1_1_ALV2 },
        { "CC-BY-3.0", CC_BY_3_0 },
        { "Mup", MUP },
        { "CECILL-1.1", CECILL_1_1 },
        { "FDK-AAC", FDK_AAC },
        { "CC-BY-3.0-IGO", CC_BY_3_0_IGO },
        { "Parity-7.0.0", PARITY_7_0_0 },
        { "MPEG-SSG", MPEG_SSG },
        { "AFL-2.0", AFL_2_0 },
        { "CC-BY-SA-2.0", CC_BY_SA_2_0 },
        { "OpenSSL-standalone", OPENSSL_STANDALONE },
        { "HPND-UC-export-US", HPND_UC_EXPORT_US },
        { "SHL-0.5", SHL_0_5 },
        { "CMU-Mach", CMU_MACH },
        { "CC-BY-1.0", CC_BY_1_0 },
        { "Afmparse", AFMPARSE },
        { "SimPL-2.0", SIMPL_2_0 },
        { "GPL-3.0-with-GCC-exception", GPL_3_0_WITH_GCC_EXCEPTION },
        { "CC-PDDC", CC_PDDC },
        { "TOSL", TOSL },
        { "IBM-pibs", IBM_PIBS },
        { "AFL-2.1", AFL_2_1 },
        { "ECL-1.0", ECL_1_0 },
        { "GFDL-1.2-no-invariants-only", GFDL_1_2_NO_INVARIANTS_ONLY },
        { "CC-BY-NC-SA-3.0-DE", CC_BY_NC_SA_3_0_DE },
        { "Spencer-94", SPENCER_94 },
        { "LAL-1.2", LAL_1_2 },
        { "GPL-3.0-only", GPL_3_0_ONLY },
        { "BSD-Systemics", BSD_SYSTEMICS },
        { "HPND-sell-MIT-disclaimer-xserver", HPND_SELL_MIT_DISCLAIMER_XSERVER },
        { "Newsletr", NEWSLETR },
        { "CECILL-C", CECILL_C },
        { "any-OSI", ANY_OSI },
        { "PDDL-1.0", PDDL_1_0 },
        { "GFDL-1.3-only", GFDL_1_3_ONLY },
        { "Noweb", NOWEB },
        { "EUPL-1.0", EUPL_1_0 },
        { "ssh-keyscan", SSH_KEYSCAN },
        { "CDLA-Permissive-2.0", CDLA_PERMISSIVE_2_0 },
        { "Fair", FAIR },
        { "Zlib", ZLIB },
        { "CC-BY-NC-ND-3.0", CC_BY_NC_ND_3_0 },
        { "DocBook-DTD", DOCBOOK_DTD },
        { "CC-BY-NC-SA-2.5", CC_BY_NC_SA_2_5 },
        { "JSON", JSON },
        { "Python-2.0.1", PYTHON_2_0_1 },
        { "AML-glslang", AML_GLSLANG },
        { "BSD-Inferno-Nettverk", BSD_INFERNO_NETTVERK },
        { "Brian-Gladman-3-Clause", BRIAN_GLADMAN_3_CLAUSE },
        { "wwl", WWL },
        { "CDDL-1.1", CDDL_1_1 },
        { "TermReadKey", TERMREADKEY },
        { "OLDAP-2.2.2", OLDAP_2_2_2 },
        { "RSA-MD", RSA_MD },
        { "BSD-2-Clause-first-lines", BSD_2_CLAUSE_FIRST_LINES },
        { "LGPL-3.0-or-later", LGPL_3_0_OR_LATER },
        { "NGPL", NGPL },
        { "eGenix", EGENIX },
        { "Sleepycat", SLEEPYCAT },
        { "Adobe-Glyph", ADOBE_GLYPH },
        { "MS-PL", MS_PL },
        { "LPPL-1.3c", LPPL_1_3C },
        { "OLDAP-2.4", OLDAP_2_4 },
        { "BSD-2-Clause-pkgconf-disclaimer", BSD_2_CLAUSE_PKGCONF_DISCLAIMER },
        { "ImageMagick", IMAGEMAGICK },
        { "OLDAP-2.0", OLDAP_2_0 },
        { "BSD-2-Clause-NetBSD", BSD_2_CLAUSE_NETBSD },
        { "xinetd", XINETD },
        { "dvipdfm", DVIPDFM },
        { "C-UDA-1.0", C_UDA_1_0 },
        { "OML", OML },
        { "OFFIS", OFFIS },
        { "TCL", TCL },
        { "HPND-Kevlin-Henney", HPND_KEVLIN_HENNEY },
        { "MakeIndex", MAKEINDEX },
        { "MTLL", MTLL },
        { "DEC-3-Clause", DEC_3_CLAUSE },
        { "Bitstream-Vera", BITSTREAM_VERA },
        { "GPL-1.0-only", GPL_1_0_ONLY },
        { "COIL-1.0", COIL_1_0 },
        { "Aladdin", ALADDIN },
        { "xzoom", XZOOM },
        { "HP-1986", HP_1986 },
        { "LGPL-2.0", LGPL_2_0 },
        { "etalab-2.0", ETALAB_2_0 },
        { "Zeeff", ZEEFF },
        { "HPND-DEC", HPND_DEC },
        { "CC-BY-NC-SA-4.0", CC_BY_NC_SA_4_0 },
        { "BSD-4-Clause-UC", BSD_4_CLAUSE_UC },
        { "GLWTPL", GLWTPL },
        { "FreeImage", FREEIMAGE },
        { "MIT", MIT },
        { "ZPL-2.1", ZPL_2_1 },
        { "Watcom-1.0", WATCOM_1_0 },
        { "LGPL-2.1-or-later", LGPL_2_1_OR_LATER },
        { "Intel-ACPI", INTEL_ACPI },
        { "LPPL-1.2", LPPL_1_2 },
        { "CC-BY-ND-4.0", CC_BY_ND_4_0 },
        { "RPL-1.1", RPL_1_1 },
        { "SOFA", SOFA },
        { "Cornell-Lossless-JPEG", CORNELL_LOSSLESS_JPEG },
        { "NIST-PD", NIST_PD },
        { "OLDAP-2.3", OLDAP_2_3 },
        { "GPL-2.0-with-autoconf-exception", GPL_2_0_WITH_AUTOCONF_EXCEPTION },
        { "Zimbra-1.4", ZIMBRA_1_4 },
        { "O-UDA-1.0", O_UDA_1_0 },
        { "CC-BY-ND-2.5", CC_BY_ND_2_5 },
        { "SugarCRM-1.1.3", SUGARCRM_1_1_3 },
        { "NetCDF", NETCDF },
        { "MIT-Khronos-old", MIT_KHRONOS_OLD },
        { "NLOD-2.0", NLOD_2_0 },
        { "MIT-Festival", MIT_FESTIVAL },
        { "SMAIL-GPL", SMAIL_GPL },
        { "w3m", W3M },
        { "CC-BY-NC-2.0", CC_BY_NC_2_0 },
        { "MIT-CMU", MIT_CMU },
        { "SMLNJ", SMLNJ },
        { "BSL-1.0", BSL_1_0 },
        { "Linux-man-pages-copyleft-2-para", LINUX_MAN_PAGES_COPYLEFT_2_PARA },
        { "GPL-2.0-or-later", GPL_2_0_OR_LATER },
        { "LGPL-2.1+", LGPL_2_1_ },
        { "MulanPSL-2.0", MULANPSL_2_0 },
        { "JPNIC", JPNIC },
        { "AFL-1.2", AFL_1_2 },
        { "MITNFA", MITNFA },
        { "generic-xts", GENERIC_XTS },
        { "zlib-acknowledgement", ZLIB_ACKNOWLEDGEMENT },
        { "CMU-Mach-nodoc", CMU_MACH_NODOC },
        { "SAX-PD-2.0", SAX_PD_2_0 },
        { "Linux-man-pages-copyleft-var", LINUX_MAN_PAGES_COPYLEFT_VAR },
        { "CDLA-Permissive-1.0", CDLA_PERMISSIVE_1_0 },
        { "mailprio", MAILPRIO },
        { "DL-DE-ZERO-2.0", DL_DE_ZERO_2_0 },
        { "EPL-2.0", EPL_2_0 },
        { "Linux-man-pages-1-para", LINUX_MAN_PAGES_1_PARA },
        { "HIDAPI", HIDAPI },
        { "OSL-1.0", OSL_1_0 },
        { "Artistic-1.0-Perl", ARTISTIC_1_0_PERL },
        { "xpp", XPP },
        { "Xfig", XFIG },
        { "CDL-1.0", CDL_1_0 },
        { "TAPR-OHL-1.0", TAPR_OHL_1_0 },
        { "BSD-Attribution-HPND-disclaimer", BSD_ATTRIBUTION_HPND_DISCLAIMER },
        { "GFDL-1.3-no-invariants-only", GFDL_1_3_NO_INVARIANTS_ONLY },
        { "3D-Slicer-1.0", _3D_SLICER_1_0 },
        { "CC-BY-3.0-US", CC_BY_3_0_US },
        { "ThirdEye", THIRDEYE },
        { "MMIXware", MMIXWARE },
        { "ODbL-1.0", ODBL_1_0 },
        { "OLDAP-2.7", OLDAP_2_7 },
        { "GFDL-1.1-or-later", GFDL_1_1_OR_LATER },
        { "Plexus", PLEXUS },
        { "CFITSIO", CFITSIO },
        { "Widget-Workshop", WIDGET_WORKSHOP },
        { "NOSL", NOSL },
        { "CAL-1.0-Combined-Work-Exception", CAL_1_0_COMBINED_WORK_EXCEPTION },
        { "GFDL-1.2-or-later", GFDL_1_2_OR_LATER },
        { "BSD-4.3RENO", BSD_4_3RENO },
        { "SGI-B-1.1", SGI_B_1_1 },
        { "CC-BY-3.0-AT", CC_BY_3_0_AT },
        { "ClArtistic", CLARTISTIC },
        { "DL-DE-BY-2.0", DL_DE_BY_2_0 },
        { "OGL-UK-3.0", OGL_UK_3_0 },
        { "PSF-2.0", PSF_2_0 },
        { "Latex2e", LATEX2E },
        { "CC-BY-SA-3.0-IGO", CC_BY_SA_3_0_IGO },
        { "DocBook-XML", DOCBOOK_XML },
        { "BSD-3-Clause-Sun", BSD_3_CLAUSE_SUN },
        { "BSD-2-Clause-Views", BSD_2_CLAUSE_VIEWS },
        { "libutil-David-Nugent", LIBUTIL_DAVID_NUGENT },
        { "bzip2-1.0.6", BZIP2_1_0_6 },
        { "CC-BY-2.0", CC_BY_2_0 },
        { "SISSL-1.2", SISSL_1_2 },
        { "CC-BY-4.0", CC_BY_4_0 },
        { "HPND-sell-variant-MIT-disclaimer", HPND_SELL_VARIANT_MIT_DISCLAIMER },
        { "ANTLR-PD", ANTLR_PD },
        { "SCEA", SCEA },
        { "Adobe-2006", ADOBE_2006 },
        { "Borceux", BORCEUX },
        { "DOC", DOC },
        { "CC-PDM-1.0", CC_PDM_1_0 },
        { "bzip2-1.0.5", BZIP2_1_0_5 },
        { "CPOL-1.02", CPOL_1_02 },
        { "CC-BY-ND-1.0", CC_BY_ND_1_0 },
        { "NCGL-UK-2.0", NCGL_UK_2_0 },
        { "copyleft-next-0.3.0", COPYLEFT_NEXT_0_3_0 },
        { "InnoSetup", INNOSETUP },
        { "GPL-1.0-or-later", GPL_1_0_OR_LATER },
        { "Catharon", CATHARON },
        { "CC-BY-NC-1.0", CC_BY_NC_1_0 },
        { "MIPS", MIPS },
        { "copyleft-next-0.3.1", COPYLEFT_NEXT_0_3_1 },
        { "HPND-INRIA-IMAG", HPND_INRIA_IMAG },
        { "ISC-Veillard", ISC_VEILLARD },
        { "GFDL-1.3-no-invariants-or-later", GFDL_1_3_NO_INVARIANTS_OR_LATER },
        { "CC-BY-3.0-NL", CC_BY_3_0_NL },
        { "CC-BY-ND-2.0", CC_BY_ND_2_0 },
        { "CryptoSwift", CRYPTOSWIFT },
        { "BSD-3-Clause-HP", BSD_3_CLAUSE_HP },
        { "CATOSL-1.1", CATOSL_1_1 },
        { "NCSA", NCSA },
        { "Spencer-99", SPENCER_99 },
        { "DRL-1.1", DRL_1_1 },
        { "BSD-3-Clause-No-Nuclear-License", BSD_3_CLAUSE_NO_NUCLEAR_LICENSE },
        { "MIT-0", MIT_0 },
        { "Sendmail-8.23", SENDMAIL_8_23 },
        { "X11-distribute-modifications-variant", X11_DISTRIBUTE_MODIFICATIONS_VARIANT },
        { "Dotseqn", DOTSEQN },
        { "OGL-UK-1.0", OGL_UK_1_0 },
        { "EUPL-1.1", EUPL_1_1 },
        { "App-s2p", APP_S2P },
        { "Vim", VIM },
        { "CC-BY-ND-3.0", CC_BY_ND_3_0 },
        { "Unlicense-libwhirlpool", UNLICENSE_LIBWHIRLPOOL },
        { "MIT-advertising", MIT_ADVERTISING },
        { "magaz", MAGAZ },
        { "IJG-short", IJG_SHORT },
        { "CC-BY-SA-4.0", CC_BY_SA_4_0 },
        { "Saxpath", SAXPATH },
        { "ASWF-Digital-Assets-1.1", ASWF_DIGITAL_ASSETS_1_1 },
        { "CC-BY-NC-SA-2.0-UK", CC_BY_NC_SA_2_0_UK },
        { "NCBI-PD", NCBI_PD },
        { "LZMA-SDK-9.22", LZMA_SDK_9_22 },
        { "LPL-1.02", LPL_1_02 },
        { "GFDL-1.2-no-invariants-or-later", GFDL_1_2_NO_INVARIANTS_OR_LATER },
        { "CC-BY-NC-SA-3.0", CC_BY_NC_SA_3_0 },
        { "CPAL-1.0", CPAL_1_0 },
        { "OLDAP-2.6", OLDAP_2_6 },
        { "APSL-1.0", APSL_1_0 },
        { "gtkbook", GTKBOOK },
        { "mpi-permissive", MPI_PERMISSIVE },
        { "APL-1.0", APL_1_0 },
        { "checkmk", CHECKMK },
        { "BSD-3-Clause-flex", BSD_3_CLAUSE_FLEX },
        { "EPICS", EPICS },
        { "psfrag", PSFRAG },
        { "HPND-Markus-Kuhn", HPND_MARKUS_KUHN },
        { "GPL-3.0-with-autoconf-exception", GPL_3_0_WITH_AUTOCONF_EXCEPTION },
        { "libtiff", LIBTIFF },
        { "man2html", MAN2HTML },
        { "AdaCore-doc", ADACORE_DOC },
        { "CC-BY-2.5", CC_BY_2_5 },
        { "MIT-enna", MIT_ENNA },
        { "BlueOak-1.0.0", BLUEOAK_1_0_0 },
        { "W3C", W3C },
        { "Parity-6.0.0", PARITY_6_0_0 },
        { "LPPL-1.1", LPPL_1_1 },
        { "Qhull", QHULL },
        { "X11-swapped", X11_SWAPPED },
        { "XFree86-1.1", XFREE86_1_1 },
        { "Kastrup", KASTRUP },
        { "StandardML-NJ", STANDARDML_NJ },
        { "AAL", AAL },
        { "Boehm-GC", BOEHM_GC },
        { "FSL-1.1-MIT", FSL_1_1_MIT },
        { "FBM", FBM },
        { "Artistic-1.0", ARTISTIC_1_0 },
        { "BSD-Source-Code", BSD_SOURCE_CODE },
        { "CC-BY-SA-1.0", CC_BY_SA_1_0 },
        { "Glide", GLIDE },
        { "CECILL-1.0", CECILL_1_0 },
        { "DRL-1.0", DRL_1_0 },
        { "LiLiQ-R-1.1", LILIQ_R_1_1 },
        { "eCos-2.0", ECOS_2_0 },
        { "Libpng", LIBPNG },
        { "Zimbra-1.3", ZIMBRA_1_3 },
        { "Info-ZIP", INFO_ZIP },
        { "CECILL-2.1", CECILL_2_1 },
        { "IPA", IPA },
        { "BSD-3-Clause-Clear", BSD_3_CLAUSE_CLEAR },
        { "ErlPL-1.1", ERLPL_1_1 },
        { "CNRI-Python-GPL-Compatible", CNRI_PYTHON_GPL_COMPATIBLE },
        { "OCLC-2.0", OCLC_2_0 },
        { "SWL", SWL },
        { "SMPPL", SMPPL },
        { "OSL-2.1", OSL_2_1 },
        { "HPND-sell-regexpr", HPND_SELL_REGEXPR },
        { "OFL-1.1-RFN", OFL_1_1_RFN },
        { "BUSL-1.1", BUSL_1_1 },
        { "CC0-1.0", CC0_1_0 },
        { "Interbase-1.0", INTERBASE_1_0 },
        { "XSkat", XSKAT },
        { "psutils", PSUTILS },
        { "HPND-export-US-acknowledgement", HPND_EXPORT_US_ACKNOWLEDGEMENT },
        { "LiLiQ-Rplus-1.1", LILIQ_RPLUS_1_1 },
        { "Mackerras-3-Clause-acknowledgment", MACKERRAS_3_CLAUSE_ACKNOWLEDGMENT },
        { "Adobe-Display-PostScript", ADOBE_DISPLAY_POSTSCRIPT },
        { "Rdisc", RDISC },
        { "Inner-Net-2.0", INNER_NET_2_0 },
        { "Imlib2", IMLIB2 },
        { "HPND-sell-variant", HPND_SELL_VARIANT },
        { "LPL-1.0", LPL_1_0 },
        { "NLOD-1.0", NLOD_1_0 },
        { "PostgreSQL", POSTGRESQL },
        { "PHP-3.01", PHP_3_01 },
        { "Unlicense", UNLICENSE },
        { "TU-Berlin-2.0", TU_BERLIN_2_0 },
        { "xkeyboard-config-Zinoviev", XKEYBOARD_CONFIG_ZINOVIEV },
        { "ulem", ULEM },
        { "HPND-merchantability-variant", HPND_MERCHANTABILITY_VARIANT },
        { "GFDL-1.3-or-later", GFDL_1_3_OR_LATER },
        { "GPL-3.0", GPL_3_0 },
        { "BSD-2-Clause-Darwin", BSD_2_CLAUSE_DARWIN },
        { "OGL-UK-2.0", OGL_UK_2_0 },
        { "GFDL-1.2-invariants-only", GFDL_1_2_INVARIANTS_ONLY },
        { "CC-BY-NC-ND-3.0-DE", CC_BY_NC_ND_3_0_DE },
        { "CPL-1.0", CPL_1_0 },
        { "MulanPSL-1.0", MULANPSL_1_0 },
        { "CC-BY-SA-3.0-DE", CC_BY_SA_3_0_DE },
        { "EFL-1.0", EFL_1_0 },
        { "GPL-2.0+", GPL_2_0_ },
        { "MIT-Click", MIT_CLICK },
        { "Hippocratic-2.1", HIPPOCRATIC_2_1 },
        { "GFDL-1.2-invariants-or-later", GFDL_1_2_INVARIANTS_OR_LATER },
        { "OPL-UK-3.0", OPL_UK_3_0 },
        { "Ruby-pty", RUBY_PTY },
        { "CC-BY-3.0-DE", CC_BY_3_0_DE },
        { "fwlw", FWLW },
        { "MIT-feh", MIT_FEH },
        { "GPL-1.0", GPL_1_0 },
        { "APAFML", APAFML },
        { "AMPAS", AMPAS },
        { "Nokia", NOKIA },
        { "diffmark", DIFFMARK },
        { "OLDAP-2.2.1", OLDAP_2_2_1 },
        { "CC-BY-NC-SA-2.0-DE", CC_BY_NC_SA_2_0_DE },
        { "TPDL", TPDL },
        { "threeparttable", THREEPARTTABLE },
        { "RHeCos-1.1", RHECOS_1_1 },
        { "OCCT-PL", OCCT_PL },
        { "HaskellReport", HASKELLREPORT },
        { "GPL-2.0-with-GCC-exception", GPL_2_0_WITH_GCC_EXCEPTION },
        { "PADL", PADL },
        { "NASA-1.3", NASA_1_3 },
        { "LGPL-3.0+", LGPL_3_0_ },
        { "CC-SA-1.0", CC_SA_1_0 },
        { "gnuplot", GNUPLOT },
        { "RPL-1.5", RPL_1_5 },
        { "JPL-image", JPL_IMAGE },
        { "CERN-OHL-W-2.0", CERN_OHL_W_2_0 },
        { "Jam", JAM },
        { "BSD-3-Clause-No-Nuclear-Warranty", BSD_3_CLAUSE_NO_NUCLEAR_WARRANTY },
        { "TrustedQSL", TRUSTEDQSL },
        { "OSL-1.1", OSL_1_1 },
        { "AGPL-1.0-only", AGPL_1_0_ONLY },
        { "Martin-Birgmeier", MARTIN_BIRGMEIER },
        { "GPL-2.0-only", GPL_2_0_ONLY },
        { "SGI-B-2.0", SGI_B_2_0 }
    };


    private static string ReadResource(string name)
    {
        // Determine path
        var assembly = System.Reflection.Assembly.GetExecutingAssembly();
        string resourcePath = name;
        
        var resources = assembly.GetManifestResourceNames();
        resourcePath = resources.Single(str => str == $"Spdx3.LicenseData.{name}");

        using (Stream stream = assembly.GetManifestResourceStream(resourcePath))
        using (StreamReader reader = new StreamReader(stream))
        {
            return reader.ReadToEnd();
        }
    }
}
