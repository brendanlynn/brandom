# brandom

'brandom' (Brendan's Random) is a CLI for users to quickly and conveniently generate large or type-specific random numbers. Once installed, it can be called on the command line by that name.

The Google random number generator or other random number generators available on the internet can rarely generate large numbers. This random number generator has the capacity to generate random numbers in a range much larger than that of a mere 32-bit signed or unsigned integer.

A NuGet package for this project may be found [here](https://www.nuget.org/packages/brendanlynn.brandom).

The allowed commands are:

* ```brandom sbyte/int8_t/int8/i8/__int8```
  
  Generates a random number between and including -128 (-2<sup>7</sup>) and 127 (2<sup>7</sup>-1).
* ```brandom byte/uint8_t/uint8/ui8```

  Generates a random number greater than or equal to 0 and less than 255 (2<sup>8</sup>-1).
* ```brandom short/int16_t/int16/ui16/__int16```
  
  Generates a random number between and including -32768 (-2<sup>15</sup>) and 32767 (2<sup>15</sup>-1).
* ```brandom ushort/uint16_t/uint16/ui16```

  Generates a random number greater than or equal to 0 and less than 65535 (2<sup>16</sup>-1).
* ```brandom int/int32_t/int32/i32/__int32```
  
  Generates a random number between and including -2147483648 (-2<sup>31</sup>) and 2147483647 (2<sup>31</sup>-1).
* ```brandom uint/uint32_t/uint32/ui32```

  Generates a random number greater than or equal to 0 and less than 4294967295 (2<sup>32</sup>-1).
* ```brandom long/int64_t/int64/i64/__int64```
  
  Generates a random number between and including -9223372036854775808 (-2<sup>63</sup>) and 9223372036854775807 (2<sup>63</sup>-1).
* ```brandom ulong/uint64_t/uint64/ui64```

  Generates a random number greater than or equal to 0 and less than 18446744073709551615 (2<sup>64</sup>-1).
* ```brandom <upper bound>```

  Generates a random number greater than or equal to 0 and less than the value of ```<upper bound>```.
* ```brandom <lower bound> <upper bound>```

  Generates a random number greater than or equal to the value of ```<lower bound>``` and less than the value of ```<upper bound>```.
