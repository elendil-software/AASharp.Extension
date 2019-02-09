# AASharp.Extension

AASharp.Extension provides helper classes and methods allowing using [AASharp](https://github.com/jsauve/AASharp) more easily.

## Features

- Method allowing to identify the constellation corresponding to given coordinates

### Not yet released

These are feature that are not available in the NuGet package. They are available on the [develop branch](https://github.com/elendil-software/AASharp.Extension/tree/develop)

- Various classes allowing to instanciate Sky coordinates and Earth location from various input formats (DMS string, decimal value)
- Computation of horizontal coordinate of a given object for given location and DateTime
- Computation of horizontal coordinate of the Sun for given location and DateTime
- Computation of horizontal coordinate of the Moon for given location and DateTime
- Computation of the Moon illuminated fraction for given location and DateTime


## Installation 

This project is available as a NuGet package

    Install-Package IPX800cs

## Contributions

Currently very few functions are available, but others will be added. Feel free to open an [issue](https://github.com/elendil-software/AASharp.Extension/issues) to suggest new capability.

## License

AASharp.Extension is free software; you can redistribute it and/or modify it under the terms of the GNU Lesser General Public License as published by the Free Software Foundation; either version 3.0 of the License, or (at your option) any later version.

AASharp.Extension is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU Lesser General Public License for more details (<https://www.gnu.org/licenses/lgpl.html>)