﻿using System.Collections.Generic;

namespace AASharp.Extension.Constellations
{
    internal static class Constellations
    {
        /// <summary>
        /// From ftp://cdsarc.u-strasbg.fr/pub/cats/VI/42/data.dat .
        /// This collection gives the constellation boundaries.
        /// Each constellation is bounded by lines of constant RA or constant declination, in the 1875 equinox coordinate system.
        /// </summary>
        internal static ConstellationsBoundary[] Boundaries { get; } =
        {
            new ConstellationsBoundary(0.0000, 24.0000, 88.0000, "UMi"),
            new ConstellationsBoundary(8.0000, 14.5000, 86.5000, "UMi"),
            new ConstellationsBoundary(21.0000, 23.0000, 86.1667, "UMi"),
            new ConstellationsBoundary(18.0000, 21.0000, 86.0000, "UMi"),
            new ConstellationsBoundary(0.0000, 8.0000, 85.0000, "Cep"),
            new ConstellationsBoundary(9.1667, 10.6667, 82.0000, "Cam"),
            new ConstellationsBoundary(0.0000, 5.0000, 80.0000, "Cep"),
            new ConstellationsBoundary(10.6667, 14.5000, 80.0000, "Cam"),
            new ConstellationsBoundary(17.5000, 18.0000, 80.0000, "UMi"),
            new ConstellationsBoundary(20.1667, 21.0000, 80.0000, "Dra"),
            new ConstellationsBoundary(0.0000, 3.5083, 77.0000, "Cep"),
            new ConstellationsBoundary(11.5000, 13.5833, 77.0000, "Cam"),
            new ConstellationsBoundary(16.5333, 17.5000, 75.0000, "UMi"),
            new ConstellationsBoundary(20.1667, 20.6667, 75.0000, "Cep"),
            new ConstellationsBoundary(7.9667, 9.1667, 73.5000, "Cam"),
            new ConstellationsBoundary(9.1667, 11.3333, 73.5000, "Dra"),
            new ConstellationsBoundary(13.0000, 16.5333, 70.0000, "UMi"),
            new ConstellationsBoundary(3.1000, 3.4167, 68.0000, "Cas"),
            new ConstellationsBoundary(20.4167, 20.6667, 67.0000, "Dra"),
            new ConstellationsBoundary(11.3333, 12.0000, 66.5000, "Dra"),
            new ConstellationsBoundary(0.0000, 0.3333, 66.0000, "Cep"),
            new ConstellationsBoundary(14.0000, 15.6667, 66.0000, "UMi"),
            new ConstellationsBoundary(23.5833, 24.0000, 66.0000, "Cep"),
            new ConstellationsBoundary(12.0000, 13.5000, 64.0000, "Dra"),
            new ConstellationsBoundary(13.5000, 14.4167, 63.0000, "Dra"),
            new ConstellationsBoundary(23.1667, 23.5833, 63.0000, "Cep"),
            new ConstellationsBoundary(6.1000, 7.0000, 62.0000, "Cam"),
            new ConstellationsBoundary(20.0000, 20.4167, 61.5000, "Dra"),
            new ConstellationsBoundary(20.5367, 20.6000, 60.9167, "Cep"),
            new ConstellationsBoundary(7.0000, 7.9667, 60.0000, "Cam"),
            new ConstellationsBoundary(7.9667, 8.4167, 60.0000, "UMa"),
            new ConstellationsBoundary(19.7667, 20.0000, 59.5000, "Dra"),
            new ConstellationsBoundary(20.0000, 20.5367, 59.5000, "Cep"),
            new ConstellationsBoundary(22.8667, 23.1667, 59.0833, "Cep"),
            new ConstellationsBoundary(0.0000, 2.4333, 58.5000, "Cas"),
            new ConstellationsBoundary(19.4167, 19.7667, 58.0000, "Dra"),
            new ConstellationsBoundary(1.7000, 1.9083, 57.5000, "Cas"),
            new ConstellationsBoundary(2.4333, 3.1000, 57.0000, "Cas"),
            new ConstellationsBoundary(3.1000, 3.1667, 57.0000, "Cam"),
            new ConstellationsBoundary(22.3167, 22.8667, 56.2500, "Cep"),
            new ConstellationsBoundary(5.0000, 6.1000, 56.0000, "Cam"),
            new ConstellationsBoundary(14.0333, 14.4167, 55.5000, "UMa"),
            new ConstellationsBoundary(14.4167, 19.4167, 55.5000, "Dra"),
            new ConstellationsBoundary(3.1667, 3.3333, 55.0000, "Cam"),
            new ConstellationsBoundary(22.1333, 22.3167, 55.0000, "Cep"),
            new ConstellationsBoundary(20.6000, 21.9667, 54.8333, "Cep"),
            new ConstellationsBoundary(0.0000, 1.7000, 54.0000, "Cas"),
            new ConstellationsBoundary(6.1000, 6.5000, 54.0000, "Lyn"),
            new ConstellationsBoundary(12.0833, 13.5000, 53.0000, "UMa"),
            new ConstellationsBoundary(15.2500, 15.7500, 53.0000, "Dra"),
            new ConstellationsBoundary(21.9667, 22.1333, 52.7500, "Cep"),
            new ConstellationsBoundary(3.3333, 5.0000, 52.5000, "Cam"),
            new ConstellationsBoundary(22.8667, 23.3333, 52.5000, "Cas"),
            new ConstellationsBoundary(15.7500, 17.0000, 51.5000, "Dra"),
            new ConstellationsBoundary(2.0417, 2.5167, 50.5000, "Per"),
            new ConstellationsBoundary(17.0000, 18.2333, 50.5000, "Dra"),
            new ConstellationsBoundary(0.0000, 1.3667, 50.0000, "Cas"),
            new ConstellationsBoundary(1.3667, 1.6667, 50.0000, "Per"),
            new ConstellationsBoundary(6.5000, 6.8000, 50.0000, "Lyn"),
            new ConstellationsBoundary(23.3333, 24.0000, 50.0000, "Cas"),
            new ConstellationsBoundary(13.5000, 14.0333, 48.5000, "UMa"),
            new ConstellationsBoundary(0.0000, 1.1167, 48.0000, "Cas"),
            new ConstellationsBoundary(23.5833, 24.0000, 48.0000, "Cas"),
            new ConstellationsBoundary(18.1750, 18.2333, 47.5000, "Her"),
            new ConstellationsBoundary(18.2333, 19.0833, 47.5000, "Dra"),
            new ConstellationsBoundary(19.0833, 19.1667, 47.5000, "Cyg"),
            new ConstellationsBoundary(1.6667, 2.0417, 47.0000, "Per"),
            new ConstellationsBoundary(8.4167, 9.1667, 47.0000, "UMa"),
            new ConstellationsBoundary(0.1667, 0.8667, 46.0000, "Cas"),
            new ConstellationsBoundary(12.0000, 12.0833, 45.0000, "UMa"),
            new ConstellationsBoundary(6.8000, 7.3667, 44.5000, "Lyn"),
            new ConstellationsBoundary(21.9083, 21.9667, 44.0000, "Cyg"),
            new ConstellationsBoundary(21.8750, 21.9083, 43.7500, "Cyg"),
            new ConstellationsBoundary(19.1667, 19.4000, 43.5000, "Cyg"),
            new ConstellationsBoundary(9.1667, 10.1667, 42.0000, "UMa"),
            new ConstellationsBoundary(10.1667, 10.7833, 40.0000, "UMa"),
            new ConstellationsBoundary(15.4333, 15.7500, 40.0000, "Boo"),
            new ConstellationsBoundary(15.7500, 16.3333, 40.0000, "Her"),
            new ConstellationsBoundary(9.2500, 9.5833, 39.7500, "Lyn"),
            new ConstellationsBoundary(0.0000, 2.5167, 36.7500, "And"),
            new ConstellationsBoundary(2.5167, 2.5667, 36.7500, "Per"),
            new ConstellationsBoundary(19.3583, 19.4000, 36.5000, "Lyr"),
            new ConstellationsBoundary(4.5000, 4.6917, 36.0000, "Per"),
            new ConstellationsBoundary(21.7333, 21.8750, 36.0000, "Cyg"),
            new ConstellationsBoundary(21.8750, 22.0000, 36.0000, "Lac"),
            new ConstellationsBoundary(6.5333, 7.3667, 35.5000, "Aur"),
            new ConstellationsBoundary(7.3667, 7.7500, 35.5000, "Lyn"),
            new ConstellationsBoundary(0.0000, 2.0000, 35.0000, "And"),
            new ConstellationsBoundary(22.0000, 22.8167, 35.0000, "Lac"),
            new ConstellationsBoundary(22.8167, 22.8667, 34.5000, "Lac"),
            new ConstellationsBoundary(22.8667, 23.5000, 34.5000, "And"),
            new ConstellationsBoundary(2.5667, 2.7167, 34.0000, "Per"),
            new ConstellationsBoundary(10.7833, 11.0000, 34.0000, "UMa"),
            new ConstellationsBoundary(12.0000, 12.3333, 34.0000, "CVn"),
            new ConstellationsBoundary(7.7500, 9.2500, 33.5000, "Lyn"),
            new ConstellationsBoundary(9.2500, 9.8833, 33.5000, "LMi"),
            new ConstellationsBoundary(0.7167, 1.4083, 33.0000, "And"),
            new ConstellationsBoundary(15.1833, 15.4333, 33.0000, "Boo"),
            new ConstellationsBoundary(23.5000, 23.7500, 32.0833, "And"),
            new ConstellationsBoundary(12.3333, 13.2500, 32.0000, "CVn"),
            new ConstellationsBoundary(23.7500, 24.0000, 31.3333, "And"),
            new ConstellationsBoundary(13.9583, 14.0333, 30.7500, "CVn"),
            new ConstellationsBoundary(2.4167, 2.7167, 30.6667, "Tri"),
            new ConstellationsBoundary(2.7167, 4.5000, 30.6667, "Per"),
            new ConstellationsBoundary(4.5000, 4.7500, 30.0000, "Aur"),
            new ConstellationsBoundary(18.1750, 19.3583, 30.0000, "Lyr"),
            new ConstellationsBoundary(11.0000, 12.0000, 29.0000, "UMa"),
            new ConstellationsBoundary(19.6667, 20.9167, 29.0000, "Cyg"),
            new ConstellationsBoundary(4.7500, 5.8833, 28.5000, "Aur"),
            new ConstellationsBoundary(9.8833, 10.5000, 28.5000, "LMi"),
            new ConstellationsBoundary(13.2500, 13.9583, 28.5000, "CVn"),
            new ConstellationsBoundary(0.0000, 0.0667, 28.0000, "And"),
            new ConstellationsBoundary(1.4083, 1.6667, 28.0000, "Tri"),
            new ConstellationsBoundary(5.8833, 6.5333, 28.0000, "Aur"),
            new ConstellationsBoundary(7.8833, 8.0000, 28.0000, "Gem"),
            new ConstellationsBoundary(20.9167, 21.7333, 28.0000, "Cyg"),
            new ConstellationsBoundary(19.2583, 19.6667, 27.5000, "Cyg"),
            new ConstellationsBoundary(1.9167, 2.4167, 27.2500, "Tri"),
            new ConstellationsBoundary(16.1667, 16.3333, 27.0000, "CrB"),
            new ConstellationsBoundary(15.0833, 15.1833, 26.0000, "Boo"),
            new ConstellationsBoundary(15.1833, 16.1667, 26.0000, "CrB"),
            new ConstellationsBoundary(18.3667, 18.8667, 26.0000, "Lyr"),
            new ConstellationsBoundary(10.7500, 11.0000, 25.5000, "LMi"),
            new ConstellationsBoundary(18.8667, 19.2583, 25.5000, "Lyr"),
            new ConstellationsBoundary(1.6667, 1.9167, 25.0000, "Tri"),
            new ConstellationsBoundary(0.7167, 0.8500, 23.7500, "Psc"),
            new ConstellationsBoundary(10.5000, 10.7500, 23.5000, "LMi"),
            new ConstellationsBoundary(21.2500, 21.4167, 23.5000, "Vul"),
            new ConstellationsBoundary(5.7000, 5.8833, 22.8333, "Tau"),
            new ConstellationsBoundary(0.0667, 0.1417, 22.0000, "And"),
            new ConstellationsBoundary(15.9167, 16.0333, 22.0000, "Ser"),
            new ConstellationsBoundary(5.8833, 6.2167, 21.5000, "Gem"),
            new ConstellationsBoundary(19.8333, 20.2500, 21.2500, "Vul"),
            new ConstellationsBoundary(18.8667, 19.2500, 21.0833, "Vul"),
            new ConstellationsBoundary(0.1417, 0.8500, 21.0000, "And"),
            new ConstellationsBoundary(20.2500, 20.5667, 20.5000, "Vul"),
            new ConstellationsBoundary(7.8083, 7.8833, 20.0000, "Gem"),
            new ConstellationsBoundary(20.5667, 21.2500, 19.5000, "Vul"),
            new ConstellationsBoundary(19.2500, 19.8333, 19.1667, "Vul"),
            new ConstellationsBoundary(3.2833, 3.3667, 19.0000, "Ari"),
            new ConstellationsBoundary(18.8667, 19.0000, 18.5000, "Sge"),
            new ConstellationsBoundary(5.7000, 5.7667, 18.0000, "Ori"),
            new ConstellationsBoundary(6.2167, 6.3083, 17.5000, "Gem"),
            new ConstellationsBoundary(19.0000, 19.8333, 16.1667, "Sge"),
            new ConstellationsBoundary(4.9667, 5.3333, 16.0000, "Tau"),
            new ConstellationsBoundary(15.9167, 16.0833, 16.0000, "Her"),
            new ConstellationsBoundary(19.8333, 20.2500, 15.7500, "Sge"),
            new ConstellationsBoundary(4.6167, 4.9667, 15.5000, "Tau"),
            new ConstellationsBoundary(5.3333, 5.6000, 15.5000, "Tau"),
            new ConstellationsBoundary(12.8333, 13.5000, 15.0000, "Com"),
            new ConstellationsBoundary(17.2500, 18.2500, 14.3333, "Her"),
            new ConstellationsBoundary(11.8667, 12.8333, 14.0000, "Com"),
            new ConstellationsBoundary(7.5000, 7.8083, 13.5000, "Gem"),
            new ConstellationsBoundary(16.7500, 17.2500, 12.8333, "Her"),
            new ConstellationsBoundary(0.0000, 0.1417, 12.5000, "Peg"),
            new ConstellationsBoundary(5.6000, 5.7667, 12.5000, "Tau"),
            new ConstellationsBoundary(7.0000, 7.5000, 12.5000, "Gem"),
            new ConstellationsBoundary(21.1167, 21.3333, 12.5000, "Peg"),
            new ConstellationsBoundary(6.3083, 6.9333, 12.0000, "Gem"),
            new ConstellationsBoundary(18.2500, 18.8667, 12.0000, "Her"),
            new ConstellationsBoundary(20.8750, 21.0500, 11.8333, "Del"),
            new ConstellationsBoundary(21.0500, 21.1167, 11.8333, "Peg"),
            new ConstellationsBoundary(11.5167, 11.8667, 11.0000, "Leo"),
            new ConstellationsBoundary(6.2417, 6.3083, 10.0000, "Ori"),
            new ConstellationsBoundary(6.9333, 7.0000, 10.0000, "Gem"),
            new ConstellationsBoundary(7.8083, 7.9250, 10.0000, "Cnc"),
            new ConstellationsBoundary(23.8333, 24.0000, 10.0000, "Peg"),
            new ConstellationsBoundary(1.6667, 3.2833, 9.9167, "Ari"),
            new ConstellationsBoundary(20.1417, 20.3000, 8.5000, "Del"),
            new ConstellationsBoundary(13.5000, 15.0833, 8.0000, "Boo"),
            new ConstellationsBoundary(22.7500, 23.8333, 7.5000, "Peg"),
            new ConstellationsBoundary(7.9250, 9.2500, 7.0000, "Cnc"),
            new ConstellationsBoundary(9.2500, 10.7500, 7.0000, "Leo"),
            new ConstellationsBoundary(18.2500, 18.6622, 6.2500, "Oph"),
            new ConstellationsBoundary(18.6622, 18.8667, 6.2500, "Aql"),
            new ConstellationsBoundary(20.8333, 20.8750, 6.0000, "Del"),
            new ConstellationsBoundary(7.0000, 7.0167, 5.5000, "CMi"),
            new ConstellationsBoundary(18.2500, 18.4250, 4.5000, "Ser"),
            new ConstellationsBoundary(16.0833, 16.7500, 4.0000, "Her"),
            new ConstellationsBoundary(18.2500, 18.4250, 3.0000, "Oph"),
            new ConstellationsBoundary(21.4667, 21.6667, 2.7500, "Peg"),
            new ConstellationsBoundary(0.0000, 2.0000, 2.0000, "Psc"),
            new ConstellationsBoundary(18.5833, 18.8667, 2.0000, "Ser"),
            new ConstellationsBoundary(20.3000, 20.8333, 2.0000, "Del"),
            new ConstellationsBoundary(20.8333, 21.3333, 2.0000, "Equ"),
            new ConstellationsBoundary(21.3333, 21.4667, 2.0000, "Peg"),
            new ConstellationsBoundary(22.0000, 22.7500, 2.0000, "Peg"),
            new ConstellationsBoundary(21.6667, 22.0000, 1.7500, "Peg"),
            new ConstellationsBoundary(7.0167, 7.2000, 1.5000, "CMi"),
            new ConstellationsBoundary(3.5833, 4.6167, 0.0000, "Tau"),
            new ConstellationsBoundary(4.6167, 4.6667, 0.0000, "Ori"),
            new ConstellationsBoundary(7.2000, 8.0833, 0.0000, "CMi"),
            new ConstellationsBoundary(14.6667, 15.0833, 0.0000, "Vir"),
            new ConstellationsBoundary(17.8333, 18.2500, 0.0000, "Oph"),
            new ConstellationsBoundary(2.6500, 3.2833, -1.7500, "Cet"),
            new ConstellationsBoundary(3.2833, 3.5833, -1.7500, "Tau"),
            new ConstellationsBoundary(15.0833, 16.2667, -3.2500, "Ser"),
            new ConstellationsBoundary(4.6667, 5.0833, -4.0000, "Ori"),
            new ConstellationsBoundary(5.8333, 6.2417, -4.0000, "Ori"),
            new ConstellationsBoundary(17.8333, 17.9667, -4.0000, "Ser"),
            new ConstellationsBoundary(18.2500, 18.5833, -4.0000, "Ser"),
            new ConstellationsBoundary(18.5833, 18.8667, -4.0000, "Aql"),
            new ConstellationsBoundary(22.7500, 23.8333, -4.0000, "Psc"),
            new ConstellationsBoundary(10.7500, 11.5167, -6.0000, "Leo"),
            new ConstellationsBoundary(11.5167, 11.8333, -6.0000, "Vir"),
            new ConstellationsBoundary(0.0000, 0.3333, -7.0000, "Psc"),
            new ConstellationsBoundary(23.8333, 24.0000, -7.0000, "Psc"),
            new ConstellationsBoundary(14.2500, 14.6667, -8.0000, "Vir"),
            new ConstellationsBoundary(15.9167, 16.2667, -8.0000, "Oph"),
            new ConstellationsBoundary(20.0000, 20.5333, -9.0000, "Aql"),
            new ConstellationsBoundary(21.3333, 21.8667, -9.0000, "Aqr"),
            new ConstellationsBoundary(17.1667, 17.9667, -10.0000, "Oph"),
            new ConstellationsBoundary(5.8333, 8.0833, -11.0000, "Mon"),
            new ConstellationsBoundary(4.9167, 5.0833, -11.0000, "Eri"),
            new ConstellationsBoundary(5.0833, 5.8333, -11.0000, "Ori"),
            new ConstellationsBoundary(8.0833, 8.3667, -11.0000, "Hya"),
            new ConstellationsBoundary(9.5833, 10.7500, -11.0000, "Sex"),
            new ConstellationsBoundary(11.8333, 12.8333, -11.0000, "Vir"),
            new ConstellationsBoundary(17.5833, 17.6667, -11.6667, "Oph"),
            new ConstellationsBoundary(18.8667, 20.0000, -12.0333, "Aql"),
            new ConstellationsBoundary(4.8333, 4.9167, -14.5000, "Eri"),
            new ConstellationsBoundary(20.5333, 21.3333, -15.0000, "Aqr"),
            new ConstellationsBoundary(17.1667, 18.2500, -16.0000, "Ser"),
            new ConstellationsBoundary(18.2500, 18.8667, -16.0000, "Sct"),
            new ConstellationsBoundary(8.3667, 8.5833, -17.0000, "Hya"),
            new ConstellationsBoundary(16.2667, 16.3750, -18.2500, "Oph"),
            new ConstellationsBoundary(8.5833, 9.0833, -19.0000, "Hya"),
            new ConstellationsBoundary(10.7500, 10.8333, -19.0000, "Crt"),
            new ConstellationsBoundary(16.2667, 16.3750, -19.2500, "Sco"),
            new ConstellationsBoundary(15.6667, 15.9167, -20.0000, "Lib"),
            new ConstellationsBoundary(12.5833, 12.8333, -22.0000, "Crv"),
            new ConstellationsBoundary(12.8333, 14.2500, -22.0000, "Vir"),
            new ConstellationsBoundary(9.0833, 9.7500, -24.0000, "Hya"),
            new ConstellationsBoundary(1.6667, 2.6500, -24.3833, "Cet"),
            new ConstellationsBoundary(2.6500, 3.7500, -24.3833, "Eri"),
            new ConstellationsBoundary(10.8333, 11.8333, -24.5000, "Crt"),
            new ConstellationsBoundary(11.8333, 12.5833, -24.5000, "Crv"),
            new ConstellationsBoundary(14.2500, 14.9167, -24.5000, "Lib"),
            new ConstellationsBoundary(16.2667, 16.7500, -24.5833, "Oph"),
            new ConstellationsBoundary(0.0000, 1.6667, -25.5000, "Cet"),
            new ConstellationsBoundary(21.3333, 21.8667, -25.5000, "Cap"),
            new ConstellationsBoundary(21.8667, 23.8333, -25.5000, "Aqr"),
            new ConstellationsBoundary(23.8333, 24.0000, -25.5000, "Cet"),
            new ConstellationsBoundary(9.7500, 10.2500, -26.5000, "Hya"),
            new ConstellationsBoundary(4.7000, 4.8333, -27.2500, "Eri"),
            new ConstellationsBoundary(4.8333, 6.1167, -27.2500, "Lep"),
            new ConstellationsBoundary(20.0000, 21.3333, -28.0000, "Cap"),
            new ConstellationsBoundary(10.2500, 10.5833, -29.1667, "Hya"),
            new ConstellationsBoundary(12.5833, 14.9167, -29.5000, "Hya"),
            new ConstellationsBoundary(14.9167, 15.6667, -29.5000, "Lib"),
            new ConstellationsBoundary(15.6667, 16.0000, -29.5000, "Sco"),
            new ConstellationsBoundary(4.5833, 4.7000, -30.0000, "Eri"),
            new ConstellationsBoundary(16.7500, 17.6000, -30.0000, "Oph"),
            new ConstellationsBoundary(17.6000, 17.8333, -30.0000, "Sgr"),
            new ConstellationsBoundary(10.5833, 10.8333, -31.1667, "Hya"),
            new ConstellationsBoundary(6.1167, 7.3667, -33.0000, "CMa"),
            new ConstellationsBoundary(12.2500, 12.5833, -33.0000, "Hya"),
            new ConstellationsBoundary(10.8333, 12.2500, -35.0000, "Hya"),
            new ConstellationsBoundary(3.5000, 3.7500, -36.0000, "For"),
            new ConstellationsBoundary(8.3667, 9.3667, -36.7500, "Pyx"),
            new ConstellationsBoundary(4.2667, 4.5833, -37.0000, "Eri"),
            new ConstellationsBoundary(17.8333, 19.1667, -37.0000, "Sgr"),
            new ConstellationsBoundary(21.3333, 23.0000, -37.0000, "PsA"),
            new ConstellationsBoundary(23.0000, 23.3333, -37.0000, "Scl"),
            new ConstellationsBoundary(3.0000, 3.5000, -39.5833, "For"),
            new ConstellationsBoundary(9.3667, 11.0000, -39.7500, "Ant"),
            new ConstellationsBoundary(0.0000, 1.6667, -40.0000, "Scl"),
            new ConstellationsBoundary(1.6667, 3.0000, -40.0000, "For"),
            new ConstellationsBoundary(3.8667, 4.2667, -40.0000, "Eri"),
            new ConstellationsBoundary(23.3333, 24.0000, -40.0000, "Scl"),
            new ConstellationsBoundary(14.1667, 14.9167, -42.0000, "Cen"),
            new ConstellationsBoundary(15.6667, 16.0000, -42.0000, "Lup"),
            new ConstellationsBoundary(16.0000, 16.4208, -42.0000, "Sco"),
            new ConstellationsBoundary(4.8333, 5.0000, -43.0000, "Cae"),
            new ConstellationsBoundary(5.0000, 6.5833, -43.0000, "Col"),
            new ConstellationsBoundary(8.0000, 8.3667, -43.0000, "Pup"),
            new ConstellationsBoundary(3.4167, 3.8667, -44.0000, "Eri"),
            new ConstellationsBoundary(16.4208, 17.8333, -45.5000, "Sco"),
            new ConstellationsBoundary(17.8333, 19.1667, -45.5000, "CrA"),
            new ConstellationsBoundary(19.1667, 20.3333, -45.5000, "Sgr"),
            new ConstellationsBoundary(20.3333, 21.3333, -45.5000, "Mic"),
            new ConstellationsBoundary(3.0000, 3.4167, -46.0000, "Eri"),
            new ConstellationsBoundary(4.5000, 4.8333, -46.5000, "Cae"),
            new ConstellationsBoundary(15.3333, 15.6667, -48.0000, "Lup"),
            new ConstellationsBoundary(0.0000, 2.3333, -48.1667, "Phe"),
            new ConstellationsBoundary(2.6667, 3.0000, -49.0000, "Eri"),
            new ConstellationsBoundary(4.0833, 4.2667, -49.0000, "Hor"),
            new ConstellationsBoundary(4.2667, 4.5000, -49.0000, "Cae"),
            new ConstellationsBoundary(21.3333, 22.0000, -50.0000, "Gru"),
            new ConstellationsBoundary(6.0000, 8.0000, -50.7500, "Pup"),
            new ConstellationsBoundary(8.0000, 8.1667, -50.7500, "Vel"),
            new ConstellationsBoundary(2.4167, 2.6667, -51.0000, "Eri"),
            new ConstellationsBoundary(3.8333, 4.0833, -51.0000, "Hor"),
            new ConstellationsBoundary(0.0000, 1.8333, -51.5000, "Phe"),
            new ConstellationsBoundary(6.0000, 6.1667, -52.5000, "Car"),
            new ConstellationsBoundary(8.1667, 8.4500, -53.0000, "Vel"),
            new ConstellationsBoundary(3.5000, 3.8333, -53.1667, "Hor"),
            new ConstellationsBoundary(3.8333, 4.0000, -53.1667, "Dor"),
            new ConstellationsBoundary(0.0000, 1.5833, -53.5000, "Phe"),
            new ConstellationsBoundary(2.1667, 2.4167, -54.0000, "Eri"),
            new ConstellationsBoundary(4.5000, 5.0000, -54.0000, "Pic"),
            new ConstellationsBoundary(15.0500, 15.3333, -54.0000, "Lup"),
            new ConstellationsBoundary(8.4500, 8.8333, -54.5000, "Vel"),
            new ConstellationsBoundary(6.1667, 6.5000, -55.0000, "Car"),
            new ConstellationsBoundary(11.8333, 12.8333, -55.0000, "Cen"),
            new ConstellationsBoundary(14.1667, 15.0500, -55.0000, "Lup"),
            new ConstellationsBoundary(15.0500, 15.3333, -55.0000, "Nor"),
            new ConstellationsBoundary(4.0000, 4.3333, -56.5000, "Dor"),
            new ConstellationsBoundary(8.8333, 11.0000, -56.5000, "Vel"),
            new ConstellationsBoundary(11.0000, 11.2500, -56.5000, "Cen"),
            new ConstellationsBoundary(17.5000, 18.0000, -57.0000, "Ara"),
            new ConstellationsBoundary(18.0000, 20.3333, -57.0000, "Tel"),
            new ConstellationsBoundary(22.0000, 23.3333, -57.0000, "Gru"),
            new ConstellationsBoundary(3.2000, 3.5000, -57.5000, "Hor"),
            new ConstellationsBoundary(5.0000, 5.5000, -57.5000, "Pic"),
            new ConstellationsBoundary(6.5000, 6.8333, -58.0000, "Car"),
            new ConstellationsBoundary(0.0000, 1.3333, -58.5000, "Phe"),
            new ConstellationsBoundary(1.3333, 2.1667, -58.5000, "Eri"),
            new ConstellationsBoundary(23.3333, 24.0000, -58.5000, "Phe"),
            new ConstellationsBoundary(4.3333, 4.5833, -59.0000, "Dor"),
            new ConstellationsBoundary(15.3333, 16.4208, -60.0000, "Nor"),
            new ConstellationsBoundary(20.3333, 21.3333, -60.0000, "Ind"),
            new ConstellationsBoundary(5.5000, 6.0000, -61.0000, "Pic"),
            new ConstellationsBoundary(15.1667, 15.3333, -61.0000, "Cir"),
            new ConstellationsBoundary(16.4208, 16.5833, -61.0000, "Ara"),
            new ConstellationsBoundary(14.9167, 15.1667, -63.5833, "Cir"),
            new ConstellationsBoundary(16.5833, 16.7500, -63.5833, "Ara"),
            new ConstellationsBoundary(6.0000, 6.8333, -64.0000, "Pic"),
            new ConstellationsBoundary(6.8333, 9.0333, -64.0000, "Car"),
            new ConstellationsBoundary(11.2500, 11.8333, -64.0000, "Cen"),
            new ConstellationsBoundary(11.8333, 12.8333, -64.0000, "Cru"),
            new ConstellationsBoundary(12.8333, 14.5333, -64.0000, "Cen"),
            new ConstellationsBoundary(13.5000, 13.6667, -65.0000, "Cir"),
            new ConstellationsBoundary(16.7500, 16.8333, -65.0000, "Ara"),
            new ConstellationsBoundary(2.1667, 3.2000, -67.5000, "Hor"),
            new ConstellationsBoundary(3.2000, 4.5833, -67.5000, "Ret"),
            new ConstellationsBoundary(14.7500, 14.9167, -67.5000, "Cir"),
            new ConstellationsBoundary(16.8333, 17.5000, -67.5000, "Ara"),
            new ConstellationsBoundary(17.5000, 18.0000, -67.5000, "Pav"),
            new ConstellationsBoundary(22.0000, 23.3333, -67.5000, "Tuc"),
            new ConstellationsBoundary(4.5833, 6.5833, -70.0000, "Dor"),
            new ConstellationsBoundary(13.6667, 14.7500, -70.0000, "Cir"),
            new ConstellationsBoundary(14.7500, 17.0000, -70.0000, "TrA"),
            new ConstellationsBoundary(0.0000, 1.3333, -75.0000, "Tuc"),
            new ConstellationsBoundary(3.5000, 4.5833, -75.0000, "Hyi"),
            new ConstellationsBoundary(6.5833, 9.0333, -75.0000, "Vol"),
            new ConstellationsBoundary(9.0333, 11.2500, -75.0000, "Car"),
            new ConstellationsBoundary(11.2500, 13.6667, -75.0000, "Mus"),
            new ConstellationsBoundary(18.0000, 21.3333, -75.0000, "Pav"),
            new ConstellationsBoundary(21.3333, 23.3333, -75.0000, "Ind"),
            new ConstellationsBoundary(23.3333, 24.0000, -75.0000, "Tuc"),
            new ConstellationsBoundary(0.7500, 1.3333, -76.0000, "Tuc"),
            new ConstellationsBoundary(0.0000, 3.5000, -82.5000, "Hyi"),
            new ConstellationsBoundary(7.6667, 13.6667, -82.5000, "Cha"),
            new ConstellationsBoundary(13.6667, 18.0000, -82.5000, "Aps"),
            new ConstellationsBoundary(3.5000, 7.6667, -85.0000, "Men"),
            new ConstellationsBoundary(0.0000, 24.0000, -90.0000, "Oct")
        };

        /// <summary>
        /// The 88 constellation abbreviations and their full names and genitives
        /// </summary>
        internal static List<Constellation> ConstellationsData { get; } =
        new List<Constellation> {
            new Constellation("And", "Andromeda", "Andromedae"),
            new Constellation("Ant", "Antlia", "Antliae"),
            new Constellation("Aps", "Apus", "Apodis"),
            new Constellation("Aql", "Aquila", "Aquilae"),
            new Constellation("Aqr", "Aquarius", "Aquarii"),
            new Constellation("Ara", "Ara", "Arae"),
            new Constellation("Ari", "Aries", "Arietis"),
            new Constellation("Aur", "Auriga", "Aurigae"),
            new Constellation("Boo", "Bo\u00f6tes", "Bo\u00f6tis"),
            new Constellation("CMa", "Canis Major", "Canis Majoris"),
            new Constellation("CMi", "Canis Minor", "Canis Minoris"),
            new Constellation("CVn", "Canes Venatici", "Canum Venaticorum"),
            new Constellation("Cae", "Caelum", "Caeli"),
            new Constellation("Cam", "Camelopardalis", "Camelopardalis"),
            new Constellation("Cap", "Capricornus", "Capricorni"),
            new Constellation("Car", "Carina", "Carinae"),
            new Constellation("Cas", "Cassiopeia", "Cassiopeiae"),
            new Constellation("Cen", "Centaurus", "Centauri"),
            new Constellation("Cep", "Cepheus", "Cephei"),
            new Constellation("Cet", "Cetus", "Ceti"),
            new Constellation("Cha", "Chamaeleon", "Chamaeleontis"),
            new Constellation("Cir", "Circinus", "Circini"),
            new Constellation("Cnc", "Cancer", "Cancri"),
            new Constellation("Col", "Columba", "Columbae"),
            new Constellation("Com", "Coma Berenices", "Comae Berenices"),
            new Constellation("CrA", "Corona Australis", "Coronae Australis"),
            new Constellation("CrB", "Corona Borealis", "Coronae Borealis"),
            new Constellation("Crt", "Crater", "Crateris"),
            new Constellation("Cru", "Crux", "Crucis"),
            new Constellation("Crv", "Corvus", "Corvi"),
            new Constellation("Cyg", "Cygnus", "Cygni"),
            new Constellation("Del", "Delphinus", "Delphini"),
            new Constellation("Dor", "Dorado", "Doradus"),
            new Constellation("Dra", "Draco", "Draconis"),
            new Constellation("Equ", "Equuleus", "Equulei"),
            new Constellation("Eri", "Eridanus", "Eridani"),
            new Constellation("For", "Fornax", "Fornacis"),
            new Constellation("Gem", "Gemini", "Geminorum"),
            new Constellation("Gru", "Grus", "Gruis"),
            new Constellation("Her", "Hercules", "Herculis"),
            new Constellation("Hor", "Horologium", "Horologii"),
            new Constellation("Hya", "Hydra", "Hydrae"),
            new Constellation("Hyi", "Hydrus", "Hydri"),
            new Constellation("Ind", "Indus", "Indi"),
            new Constellation("LMi", "Leo Minor", "Leonis Minoris"),
            new Constellation("Lac", "Lacerta", "Lacertae"),
            new Constellation("Leo", "Leo", "Leonis"),
            new Constellation("Lep", "Lepus", "Leporis"),
            new Constellation("Lib", "Libra", "Librae"),
            new Constellation("Lup", "Lupus", "Lupi"),
            new Constellation("Lyn", "Lynx", "Lyncis"),
            new Constellation("Lyr", "Lyra", "Lyrae"),
            new Constellation("Men", "Mensa", "Mensae"),
            new Constellation("Mic", "Microscopium", "Microscopii"),
            new Constellation("Mon", "Monoceros", "Monocerotis"),
            new Constellation("Mus", "Musca", "Muscae"),
            new Constellation("Nor", "Norma", "Normae"),
            new Constellation("Oct", "Octans", "Octantis"),
            new Constellation("Oph", "Ophiuchus", "Ophiuchi"),
            new Constellation("Ori", "Orion", "Orionis"),
            new Constellation("Pav", "Pavo", "Pavonis"),
            new Constellation("Peg", "Pegasus", "Pegasi"),
            new Constellation("Per", "Perseus", "Persei"),
            new Constellation("Phe", "Phoenix", "Phoenicis"),
            new Constellation("Pic", "Pictor", "Pictoris"),
            new Constellation("PsA", "Piscis Austrinus", "Piscis Austrini"),
            new Constellation("Psc", "Pisces", "Piscium"),
            new Constellation("Pup", "Puppis", "Puppis"),
            new Constellation("Pyx", "Pyxis", "Pyxidis"),
            new Constellation("Ret", "Reticulum", "Reticuli"),
            new Constellation("Scl", "Sculptor", "Sculptoris"),
            new Constellation("Sco", "Scorpius", "Scorpii"),
            new Constellation("Sct", "Scutum", "Scuti"),
            new Constellation("Ser", "Serpens", "Serpentis"),
            new Constellation("Sex", "Sextans", "Sextantis"),
            new Constellation("Sge", "Sagitta", "Sagittae"),
            new Constellation("Sgr", "Sagittarius", "Sagittarii"),
            new Constellation("Tau", "Taurus", "Tauri"),
            new Constellation("Tel", "Telescopium", "Telescopii"),
            new Constellation("TrA", "Triangulum Australe", "Trianguli Australis"),
            new Constellation("Tri", "Triangulum", "Trianguli"),
            new Constellation("Tuc", "Tucana", "Tucanae"),
            new Constellation("UMa", "Ursa Major", "Ursae Majoris"),
            new Constellation("UMi", "Ursa Minor", "Ursae Minoris"),
            new Constellation("Vel", "Vela", "Velorum"),
            new Constellation("Vir", "Virgo", "Virginis"),
            new Constellation("Vol", "Volans", "Volantis"),
            new Constellation("Vul", "Vulpecula", "Vulpeculae")
        };
    }
}