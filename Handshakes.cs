/*
At the annual meeting of Board of Directors of Acme Inc. If everyone attending shakes hands exactly one time with 
every other attendee, how many handshakes are there?

Example

There are 3 attendees a, b, and c. a shakes hands with b and c, and b shakes hands with c. 
Now they have all shaken hands after  handshakes.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

static int handshake(int n) {
 
        int result = 0;
        if (n > 1) {
             
            for (int i = 1; i < n; i++){
             result = result + n - i;
            }
                return result;
         }
        else {
                return result;
            }
    }