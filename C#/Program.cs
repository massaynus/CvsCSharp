﻿using System;

namespace CS_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var chrono = new System.Diagnostics.Stopwatch();
            chrono.Start();
            
            for(int i = 0; i < 100000; i++) Test();
            
            chrono.Stop();
            Console.WriteLine("C#:\t" + chrono.ElapsedMilliseconds);
        }

        static void Test()
        {
            int count = 0, itterator = 0;

            for (int i = 0; i < 100000; i++)
                count++;

            while (true)
            {
                double root = Math.Sqrt(itterator);
                if (itterator < count)
                    itterator++;
                else
                    break;
            }

            int[] table = new int[] { 235, 221, 218, 330, 134, 544, 240, 419, 319, 282, 317, 12, 428, 459, 287, 736, 391, 489, 863, 215, 106, 94, 386, 726, 613, 253, 615, 332, 384, 300, 236, 494, 65, 675, 81, 35, 16, 183, 171, 368, 515, 168, 959, 309, 950, 448, 836, 15, 456, 747, 210, 697, 607, 412, 840, 787, 423, 217, 335, 433, 871, 138, 369, 673, 659, 43, 439, 99, 264, 392, 963, 785, 776, 873, 20, 521, 809, 883, 706, 649, 260, 283, 837, 429, 302, 618, 473, 794, 757, 159, 316, 803, 946, 311, 170, 193, 467, 720, 655, 638, 972, 739, 589, 56, 291, 198, 105, 971, 3, 626, 258, 793, 244, 484, 460, 349, 943, 520, 72, 586, 958, 897, 324, 541, 276, 621, 692, 920, 953, 595, 760, 114, 427, 733, 623, 133, 646, 481, 805, 707, 10, 502, 74, 146, 823, 108, 987, 195, 513, 870, 676, 178, 744, 226, 53, 413, 160, 839, 556, 700, 832, 966, 842, 279, 357, 472, 569, 135, 592, 162, 179, 594, 47, 315, 548, 983, 940, 398, 751, 658, 161, 471, 190, 205, 518, 322, 257, 29, 742, 383, 269, 493, 136, 851, 172, 753, 637, 152, 547, 843, 755, 432, 415, 220, 603, 801, 320, 941, 582, 338, 90, 476, 896, 144, 948, 678, 337, 780, 553, 670, 461, 150, 506, 584, 712, 768, 452, 888, 294, 951, 954, 560, 574, 116, 604, 868, 631, 149, 477, 571, 396, 83, 831, 411, 536, 344, 359, 641, 926, 853, 980, 42, 748, 321, 13, 759, 312, 306, 498, 78, 567, 992, 345, 930, 977, 737, 662, 443, 107, 374, 929, 424, 131, 653, 539, 329, 652, 375, 717, 903, 912, 628, 617, 955, 722, 811, 703, 725, 632, 562, 341, 789, 430, 718, 457, 310, 754, 6, 479, 814, 591, 194, 400, 358, 89, 976, 573, 504, 981, 80, 122, 901, 376, 177, 270, 487, 243, 403, 985, 711, 153, 654, 841, 960, 892, 865, 128, 937, 290, 906, 500, 530, 699, 445, 64, 348, 438, 182, 474, 485, 859, 854, 905, 197, 249, 579, 782, 169, 817, 952, 995, 277, 942, 425, 390, 409, 255, 738, 810, 454, 475, 933, 847, 672, 91, 783, 907, 440, 495, 232, 186, 962, 790, 881, 797, 127, 864, 566, 121, 199, 355, 331, 95, 990, 49, 770, 1, 596, 325, 480, 19, 233, 846, 137, 534, 280, 230, 968, 242, 140, 76, 275, 463, 949, 593, 176, 60, 201, 682, 166, 925, 381, 119, 994, 307, 212, 293, 469, 40, 115, 458, 482, 184, 525, 998, 829, 247, 970, 118, 342, 727, 644, 449, 685, 821, 884, 852, 483, 568, 523, 464, 918, 271, 204, 800, 624, 861, 209, 361, 499, 835, 765, 303, 989, 148, 265, 27, 328, 426, 252, 691, 141, 444, 46, 777, 714, 281, 869, 285, 581, 919, 45, 749, 292, 704, 808, 387, 213, 188, 827, 684, 225, 715, 609, 23, 462, 552, 250, 120, 526, 491, 578, 420, 203, 422, 538, 17, 791, 786, 545 };
            int length = table.Length, temp = 0;

            for (int y = 0; y < length - 1; y++)
            {
                if (table[y] < table[y + 1])
                {
                    temp = table[y + 1];
                    table[y + 1] = table[y];
                    table[y] = temp;
                }
            }
        }
    }
}
