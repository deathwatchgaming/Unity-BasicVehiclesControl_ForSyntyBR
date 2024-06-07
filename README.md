# Unity-BasicVehiclesControl_ForSyntyBR

Description:
------------


Create basic Vehicle Controllers for your Unity projects using vehicle models
from Synty Polygon Battle Royale Asset.


 Note: As this uses currently as of this writing say 7 of the vehicles from such and due to licensing such said vehicles cannot be included in this repository obviously, so, as such the provided scripts and instructions thus require having / purchasing the Synty Polygon Battle Royale Asset:  https://assetstore.unity.com/packages/3d/environments/urban/polygon-battle-royale-low-poly-3d-art-by-synty-128513


Release Intentions note:
------------------------

The intention of these releases due to only being scripts for usage with models one must already own or opt to purchase and as such was known that one could not release such models with the package here the intent was to provide basic vehicle functionality as a start point as fully functional in terms of an opinion of basic but leave out optional continuances in the hopes that these will be used as starting points for folks to continue on with and improve upon. Now, some of the things intentionally left out, umm, while all simply easy to add, lets see: say, audio sources, audio clips, particle systems for exhausts and also for explosion on turret say with on trigger raycast or projectile functionality for tank turret barrel say for example on the tank controllers as leaving these initializations of such aforementioned suggestions out was indeed intentional in the hopes that the end user will continue to add those as desired and continue to improve upon the provided start points. Also note that while yes, these are great hints, tips and or suggestions, if you were thinking say of what to add next, please note though, that is not to say if and or when I may find myself to have free time say I just may or may not opt to add such or some of such at later dates if desire or free time allows. Another thing to note is that I intentionally left out adding a fuel system to these at this time because again the intent was to provide basic functional vehicle controllers as starting points 


Vehicles Currently "Completed" & Included:
------------------------------------------


* Tank US (100% completed)
* Armored Truck (100% completed)
* Dune Buggy (100% completed)
* Humvee (100% completed)
* Six Wheel Truck (100% completed)
* Sedan (100% completed)
* Tank RU (100% completed)


Vehicles Currently "In Progress" & Not Yet Included:
----------------------------------------------------

* C-130 Airplane (50% completed) coming soon...
* Dirt Bike (90% completed) coming soon...
* Rib (15% completed)


Other Currently "In Progress" & Not Yet Included:
--------------------------------------------------


* Gas Station / Fuel System (5% Completed) coming soon...
* Engine Audio (0% Completed) coming soon...
* Horn Audio (0% Completed) coming soon...
* Reverse Beeps Audio (0% Completed) coming soon...
* Exhaust Particles (0% Completed) coming soon...
* Vehicle Damage System (0% Completed) * still considering such eventually as
  a possibility since there are provided damaged vehicle prefabs in asset

* Related Documentation(s) (0% completed) coming soon...


Player Controls: 
----------------


  Note: The following found below are related to the provided playercontrol script for usage example if say using vehicle entry script.


* Player Forward:   W
* Player Reverse:   S
* Player Left:      A
* Player Right:     D
* Player Jump:      Space
* Player Sprint:    Left Shift


Vehicle Controls: 
-----------------


  Note: The following below are related to both variations either standalone vehicle controller usage and entry script usage.


* Vehicle Forward:  W
* Vehicle Reverse:  S
* Turn Left:        A
* Turn Right:       D
* Apply Brake:      Space


Entry Script: 


  Note: The following found below are specific only when entry script is applied.


* Enter Vehicle:    E
* Exit Vehicle:     F


Note: Additional specific only to Tanks US & RU are the following controls specific to the tank turret and tank barrel movements:

* Mouse X 
* Mouse Y


Manual Setup Instruction:
-------------------------

Simply follow the documentation instruction linkages for manual setups found below.


PlayerControl:
--------------

* Example player control documentation: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Assets/PlayerControl/Documentation/PlayerControl-Documentation.txt


Vehicles Control:
-----------------

* All vehicles in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Assets/Documentation/AllControllers-wEntry-Documentation.txt


* TankUS Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Assets/VehiclesControl/TankUS/Documentation/TankUSController-Only-Documentation.txt


* TankUS Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/TankUS/Documentation/TankUSController-Spedometer-Documentation.txt


* TankUS Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Assets/VehiclesControl/TankUS/Documentation/TankUSController-Only-wEntry-Documentation.txt


* TankUS Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Assets/VehiclesControl/TankUS/Documentation/TankUSController-Spedometer-Documentation.txt


* Armored Truck Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Assets/VehiclesControl/ArmoredTruck/Documentation/ArmoredTruckController-Only-Documentation.txt


* Armored Truck Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/ArmoredTruck/Documentation/ArmoredTruckController-Spedometer-Documentation.txt


* Armored Truck Controller with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Assets/VehiclesControl/ArmoredTruck/Documentation/ArmoredTruckController-wEntry-Documentation.txt


* Armored Truck Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Assets/VehiclesControl/ArmoredTruck/Documentation/ArmoredTruckController-Spedometer-Documentation.txt


* Dune Buggy Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Assets/VehiclesControl/DuneBuggy/Documentation/DuneBuggy-wEntry-Documentation.txt


* DuneBuggy Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/DuneBuggy/Documentation/DuneBuggyController-Spedometer-Documentation.txt


* Dune Buggy Controller with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Assets/VehiclesControl/DuneBuggy/Documentation/DuneBuggy-wEntry-Documentation.txt


* DuneBuggy Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Assets/VehiclesControl/DuneBuggy/Documentation/DuneBuggyController-Spedometer-Documentation.txt


* Humvee Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Assets/VehiclesControl/Humvee/Documentation/HumveeController-Only-Documentation.txt


* Humvee Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/Humvee/Documentation/HumveeController-Spedometer-Documentation.txt


* Humvee Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Assets/VehiclesControl/Humvee/Documentation/HumveeController-wEntry-Documentation.txt


* Humvee Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Assets/VehiclesControl/Humvee/Documentation/HumveeController-Spedometer-Documentation.txt


* Six Wheel Truck Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Assets/VehiclesControl/SixWheelTruck/Documentation/SixWheelTruckController-Only-Documentation.txt


* Six Wheel Truck Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/SixWheelTruck/Documentation/SixWheelTruckTruckController-Spedometer-Documentation.txt


* Six Wheel Truck Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Assets/VehiclesControl/SixWheelTruck/Documentation/SixWheelTruckController-wEntry-Documentation.txt


* Six Wheel Truck Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Assets/VehiclesControl/SixWheelTruck/Documentation/SixWheelTruckController-Spedometer-Documentation.txt


* Sedan Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Assets/VehiclesControl/Sedan/Documentation/SedanController-Only-Documentation.txt


* Sedan Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/Sedan/Documentation/SedanController-Spedometer-Documentation.txt


* Sedan Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Assets/VehiclesControl/Sedan/Documentation/SedanController-wEntry-Documentation.txt


* Sedan Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Assets/VehiclesControl/Sedan/Documentation/SedanController-Spedometer-Documentation.txt


* TankRU Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Assets/VehiclesControl/TankRU/Documentation/TankRUController-Only-Documentation.txt


* TankRU Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/TankRU/Documentation/TankRUController-Spedometer-Documentation.txt


* TankRU Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Assets/VehiclesControl/TankRU/Documentation/TankRUController-Only-wEntry-Documentation.txt


* TankRU Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Assets/VehiclesControl/TankRU/Documentation/TankRUController-Spedometer-Documentation.txt
