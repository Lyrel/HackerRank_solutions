/*
 A person is getting ready to leave and needs a pair of matching socks. If there are  colors of socks in the drawer, 
 how many socks need to be removed to be certain of having a matching pair?

 Example n = 2;

 There are 2 colors of socks in the drawer. If they remove 2 socks, they may not match. The minimum number to insure success is 3.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
    static int maximumDraws(int n) {
 
         if (n > 1) {
             int result = n + 1;
             return result;
         } else {
             return 2;
         }

    }