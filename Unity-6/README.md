# Unity-BasicVehiclesControl_ForSyntyBR

Description:
------------


Create basic Vehicle Controllers for your Unity projects using vehicle models
from Synty Polygon Battle Royale Asset.


 Note: As this uses currently as of this writing say 7 of the vehicles types from such and due to licensing such said vehicles cannot be included in this repository obviously, so, as such the provided scripts and instructions thus require having / purchasing the Synty Polygon Battle Royale Asset:  https://assetstore.unity.com/packages/3d/environments/urban/polygon-battle-royale-low-poly-3d-art-by-synty-128513

![Preview](https://raw.githubusercontent.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/refs/heads/main/Previews/All/PolygonBatlleRoyale-Vehicles.png)


Release Intentions Note:
------------------------

The intention of these releases due to only being scripts for usage with models one must already own or opt to purchase and as such was known that one could not release such models with the package here the intent was to provide basic vehicle functionality as a start point as fully functional in terms of an opinion of basic but leave out optional continuances in the hopes that these will be used as starting points for folks to continue on with and improve upon. Now, some of the things intentionally left out, umm, while all simply easy to add, lets see: say, audio sources, audio clips, particle systems for exhausts and also for explosion on turret say with on trigger raycast or projectile functionality for tank turret barrel say for example on the tank controllers as leaving these initializations of such aforementioned suggestions out was indeed intentional in the hopes that the end user will continue to add those as desired and continue to improve upon the provided start points. Also note that while yes, these are great hints, tips and or suggestions, if you were thinking say of what to add next, please note though, that is not to say if and or when I may find myself to have free time say I just may or may not opt to add such or some of such at later dates if desire or free time allows. Another thing to note is that I intentionally left out adding a fuel system to these at this time because again the intent was to provide basic functional vehicle controllers as starting points.

NOTE: This project was developed while / for using Unity 6 


Vehicles Currently "Completed" & Included: (total: 42)
------------------------------------------------------


* Armored Truck (100% completed) (total: 6)
* Dune Buggy (100% completed) (total: 6)
* Humvee (100% completed) (total: 6)
* Six Wheel Truck (100% completed) (total: 6)
* Sedan (100% completed) (total: 6)
* Tank RU (100% completed) (total: 6)
* Tank US (100% completed) (total: 6)


Vehicles Currently "In Progress" & Not Yet Included:
----------------------------------------------------

* C-130 Airplane (...coming TBA)
* Dirt Bike (...coming TBA)
* Rib (...coming TBA)


Other Current Possibles "In Progress" & Not Yet Included:
---------------------------------------------------------

Possible future additions: (if and or when my limited free time and desire may allow)

* Gas Station / Fuel System (0% Completed) coming TBA...
* Engine Audio (0% Completed) coming TBA...
* Horn Audio (0% Completed) coming TBA...
* Reverse Beeps Audio (0% Completed) coming TBA...
* Exhaust Particles (0% Completed) coming TBA....
* Vehicle Damage System (0% Completed) coming TBA... * still considering such eventually as
  a possibility since there are provided damaged vehicle prefabs in asset
* Mesh Deformation (0% Completed) coming TBA...
* Related Documentation(s) for above (0% completed) coming TBA...


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


* Example player control documentation: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/PlayerControl/Documentation/PlayerControl-Documentation.txt


Unity 6 Bug (Related to Wheel Colliders and Center of Gravity Offset)
----------------------------------------------------------------------


NOTE: There is a bug in Unity 6 versions prior to version Unity 6
(6000.025f1) that affects wheel colliders and center of gravity offset.
This bug was reported and an official fix has thus after such been
provided. 

Prior to that fixed version if you have not yet upgraded to the fixed version
we can still provide a temporary resolution file to add to your vehicle to
sort this out.


* Temporary Unity 6 Bug Resolution: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Temporary-Resolution/Unity-6-Temporary-Resolve-Bug.txt


ATTENTION!!: This bug has been fixed in Unity 6 (6000.025f1) thus this
temporary resolution is not needed if you upgraded or ugrade to that
version+!


Vehicles Control:
-----------------


* All vehicles in scene setup (total: 42): https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/Documentation/AllVehicleControllers-wEntry-Documentation.txt


* All vehicle types in scene setup (total: 7): https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/Documentation/AllController-Types-wEntry-Documentation.txt



Armored Truck: (total: 6)
--------------------------


* ArmoredTruck01 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/ArmoredTruck/ArmoredTruck01/Documentation/ArmoredTruck01Controller-Only-Documentation.txt


* ArmoredTruck01 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/ArmoredTruck/ArmoredTruck01/Documentation/ArmoredTruck01Controller-Speedometer-Documentation.txt


* ArmoredTruck01 Controller with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/ArmoredTruck/ArmoredTruck01/Documentation/ArmoredTruck01Controller-wEntry-Documentation.txt


* ArmoredTruck01 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/ArmoredTruck/ArmoredTruck01/Documentation/ArmoredTruck01Controller-Speedometer-Documentation.txt


* ArmoredTruck02 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/ArmoredTruck/ArmoredTruck02/Documentation/ArmoredTruck02Controller-Only-Documentation.txt


* ArmoredTruck02 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/ArmoredTruck/ArmoredTruck02/Documentation/ArmoredTruck02Controller-Speedometer-Documentation.txt


* ArmoredTruck02 Controller with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/ArmoredTruck/ArmoredTruck02/Documentation/ArmoredTruck02Controller-wEntry-Documentation.txt


* ArmoredTruck02 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/ArmoredTruck/ArmoredTruck02/Documentation/ArmoredTruck02Controller-Speedometer-Documentation.txt


* ArmoredTruck03 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/ArmoredTruck/ArmoredTruck03/Documentation/ArmoredTruck03Controller-Only-Documentation.txt


* ArmoredTruck03 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/ArmoredTruck/ArmoredTruck03/Documentation/ArmoredTruck03Controller-Speedometer-Documentation.txt


* ArmoredTruck03 Controller with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/ArmoredTruck/ArmoredTruck03/Documentation/ArmoredTruck03Controller-wEntry-Documentation.txt


* ArmoredTruck03 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/ArmoredTruck/ArmoredTruck03/Documentation/ArmoredTruck03Controller-Speedometer-Documentation.txt


* ArmoredTruck04 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/ArmoredTruck/ArmoredTruck04/Documentation/ArmoredTruck04Controller-Only-Documentation.txt


* ArmoredTruck04 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/ArmoredTruck/ArmoredTruck04/Documentation/ArmoredTruck04Controller-Speedometer-Documentation.txt


* ArmoredTruck04 Controller with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/ArmoredTruck/ArmoredTruck04/Documentation/ArmoredTruck04Controller-wEntry-Documentation.txt


* ArmoredTruck04 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/ArmoredTruck/ArmoredTruck04/Documentation/ArmoredTruck04Controller-Speedometer-Documentation.txt


* ArmoredTruck05 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/ArmoredTruck/ArmoredTruck05/Documentation/ArmoredTruck05Controller-Only-Documentation.txt


* ArmoredTruck05 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/ArmoredTruck/ArmoredTruck05/Documentation/ArmoredTruck05Controller-Speedometer-Documentation.txt


* ArmoredTruck05 Controller with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/ArmoredTruck/ArmoredTruck05/Documentation/ArmoredTruck05Controller-wEntry-Documentation.txt


* ArmoredTruck05 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/ArmoredTruck/ArmoredTruck05/Documentation/ArmoredTruck05Controller-Speedometer-Documentation.txt


* ArmoredTruck06 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/ArmoredTruck/ArmoredTruck06/Documentation/ArmoredTruck06Controller-Only-Documentation.txt


* ArmoredTruck06 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/ArmoredTruck/ArmoredTruck06/Documentation/ArmoredTruck06Controller-Speedometer-Documentation.txt


* ArmoredTruck06 Controller with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/ArmoredTruck/ArmoredTruck06/Documentation/ArmoredTruck06Controller-wEntry-Documentation.txt


* ArmoredTruck06 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/ArmoredTruck/ArmoredTruck06/Documentation/ArmoredTruck06Controller-Speedometer-Documentation.txt


* All ArmoredTruck(s) in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/ArmoredTruck/Documentation/AllArmoredTruckControllers-wEntry-Documentation.txt



Dune Buggy: (total: 6)
--------------------------


* DuneBuggy01 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/DuneBuggy/DuneBuggy01/Documentation/DuneBuggy01-wEntry-Documentation.txt


* DuneBuggy01 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/DuneBuggy/DuneBuggy01/Documentation/DuneBuggy01Controller-Speedometer-Documentation.txt


* DuneBuggy01 Controller with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/DuneBuggy/DuneBuggy01/Documentation/DuneBuggy01-wEntry-Documentation.txt


* DuneBuggy01 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/DuneBuggy/DuneBuggy01/Documentation/DuneBuggy01Controller-Speedometer-Documentation.txt


* DuneBuggy02 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/DuneBuggy/DuneBuggy02/Documentation/DuneBuggy02-wEntry-Documentation.txt


* DuneBuggy02 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/DuneBuggy/DuneBuggy02/Documentation/DuneBuggy02Controller-Speedometer-Documentation.txt


* DuneBuggy02 Controller with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/DuneBuggy/DuneBuggy02/Documentation/DuneBuggy02-wEntry-Documentation.txt


* DuneBuggy02 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/DuneBuggy/DuneBuggy02/Documentation/DuneBuggy02Controller-Speedometer-Documentation.txt


* DuneBuggy03 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/DuneBuggy/DuneBuggy03/Documentation/DuneBuggy03-wEntry-Documentation.txt


* DuneBuggy03 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/DuneBuggy/DuneBuggy03/Documentation/DuneBuggy03Controller-Speedometer-Documentation.txt


* DuneBuggy03 Controller with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/DuneBuggy/DuneBuggy03/Documentation/DuneBuggy03-wEntry-Documentation.txt


* DuneBuggy03 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/DuneBuggy/DuneBuggy03/Documentation/DuneBuggy03Controller-Speedometer-Documentation.txt


* DuneBuggy04 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/DuneBuggy/DuneBuggy04/Documentation/DuneBuggy04-wEntry-Documentation.txt


* DuneBuggy04 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/DuneBuggy/DuneBuggy04/Documentation/DuneBuggy04Controller-Speedometer-Documentation.txt


* DuneBuggy04 Controller with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/DuneBuggy/DuneBuggy04/Documentation/DuneBuggy04-wEntry-Documentation.txt


* DuneBuggy04 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/DuneBuggy/DuneBuggy04/Documentation/DuneBuggy04Controller-Speedometer-Documentation.txt


* DuneBuggy05 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/DuneBuggy/DuneBuggy05/Documentation/DuneBuggy05-wEntry-Documentation.txt


* DuneBuggy05 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/DuneBuggy/DuneBuggy05/Documentation/DuneBuggy05Controller-Speedometer-Documentation.txt


* DuneBuggy05 Controller with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/DuneBuggy/DuneBuggy05/Documentation/DuneBuggy05-wEntry-Documentation.txt


* DuneBuggy05 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/DuneBuggy/DuneBuggy05/Documentation/DuneBuggy05Controller-Speedometer-Documentation.txt


* DuneBuggy06 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/DuneBuggy/DuneBuggy06/Documentation/DuneBuggy06-wEntry-Documentation.txt


* DuneBuggy06 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/DuneBuggy/DuneBuggy06/Documentation/DuneBuggy06Controller-Speedometer-Documentation.txt


* DuneBuggy06 Controller with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/DuneBuggy/DuneBuggy06/Documentation/DuneBuggy06-wEntry-Documentation.txt


* DuneBuggy06 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/DuneBuggy/DuneBuggy06/Documentation/DuneBuggy06Controller-Speedometer-Documentation.txt


* All DuneBuggy(s) in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/DuneBuggy/Documentation/AllDuneBuggyControllers-wEntry-Documentation.txt



Humvee: (total: 6)
--------------------------


* Humvee01 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/Humvee/Humvee01/Documentation/Humvee01Controller-Only-Documentation.txt


* Humvee01 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/Humvee/Humvee01/Documentation/Humvee01Controller-Speedometer-Documentation.txt


* Humvee01 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/Humvee/Humvee01/Documentation/Humvee01Controller-wEntry-Documentation.txt


* Humvee01 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/Humvee/Humvee01/Documentation/Humvee01Controller-Speedometer-Documentation.txt


* Humvee02 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/Humvee/Humvee02/Documentation/Humvee02Controller-Only-Documentation.txt


* Humvee02 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/Humvee/Humvee02/Documentation/Humvee02Controller-Speedometer-Documentation.txt


* Humvee02 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/Humvee/Humvee02/Documentation/Humvee02Controller-wEntry-Documentation.txt


* Humvee02 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/Humvee/Humvee02/Documentation/Humvee02Controller-Speedometer-Documentation.txt


* Humvee03 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/Humvee/Humvee03/Documentation/Humvee03Controller-Only-Documentation.txt


* Humvee03 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/Humvee/Humvee03/Documentation/Humvee03Controller-Speedometer-Documentation.txt


* Humvee03 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/Humvee/Humvee03/Documentation/Humvee03Controller-wEntry-Documentation.txt


* Humvee03 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/Humvee/Humvee03/Documentation/Humvee03Controller-Speedometer-Documentation.txt


* Humvee04 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/Humvee/Humvee04/Documentation/Humvee04Controller-Only-Documentation.txt


* Humvee04 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/Humvee/Humvee04/Documentation/Humvee04Controller-Speedometer-Documentation.txt


* Humvee04 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/Humvee/Humvee04/Documentation/Humvee04Controller-wEntry-Documentation.txt


* Humvee04 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/Humvee/Humvee04/Documentation/Humvee04Controller-Speedometer-Documentation.txt


* Humvee05 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/Humvee/Humvee05/Documentation/Humvee05Controller-Only-Documentation.txt


* Humvee05 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/Humvee/Humvee05/Documentation/Humvee05Controller-Speedometer-Documentation.txt


* Humvee05 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/Humvee/Humvee05/Documentation/Humvee05Controller-wEntry-Documentation.txt


* Humvee05 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/Humvee/Humvee05/Documentation/Humvee05Controller-Speedometer-Documentation.txt


* Humvee06 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/Humvee/Humvee06/Documentation/Humvee06Controller-Only-Documentation.txt


* Humvee06 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/Humvee/Humvee06/Documentation/Humvee06Controller-Speedometer-Documentation.txt


* Humvee06 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/Humvee/Humvee06/Documentation/Humvee06Controller-wEntry-Documentation.txt


* Humvee06 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/Humvee/Humvee06/Documentation/Humvee06Controller-Speedometer-Documentation.txt


* All Humvee(s) in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/Humvee/Documentation/AllHumveeControllers-wEntry-Documentation.txt



Six Wheel Truck: (total: 6)
----------------------------


* SixWheelTruck01 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/SixWheelTruck/SixWheelTruck01/Documentation/SixWheelTruck01Controller-Only-Documentation.txt


* SixWheelTruck01 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/SixWheelTruck/SixWheelTruck01/Documentation/SixWheelTruck01Controller-Speedometer-Documentation.txt


* SixWheelTruck01 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/SixWheelTruck/SixWheelTruck01/Documentation/SixWheelTruck01Controller-wEntry-Documentation.txt


* SixWheelTruck01 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/SixWheelTruck/SixWheelTruck01/Documentation/SixWheelTruck01Controller-Speedometer-Documentation.txt


* SixWheelTruck02 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/SixWheelTruck/SixWheelTruck02/Documentation/SixWheelTruck02Controller-Only-Documentation.txt


* SixWheelTruck02 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/SixWheelTruck/SixWheelTruck02/Documentation/SixWheelTruck02Controller-Speedometer-Documentation.txt


* SixWheelTruck02 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/SixWheelTruck/SixWheelTruck02/Documentation/SixWheelTruck02Controller-wEntry-Documentation.txt


* SixWheelTruck02 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/SixWheelTruck/SixWheelTruck02/Documentation/SixWheelTruck02Controller-Speedometer-Documentation.txt


* SixWheelTruck03 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/SixWheelTruck/SixWheelTruck03/Documentation/SixWheelTruck03Controller-Only-Documentation.txt


* SixWheelTruck03 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/SixWheelTruck/SixWheelTruck03/Documentation/SixWheelTruck03Controller-Speedometer-Documentation.txt


* SixWheelTruck03 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/SixWheelTruck/SixWheelTruck03/Documentation/SixWheelTruck03Controller-wEntry-Documentation.txt


* SixWheelTruck03 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/SixWheelTruck/SixWheelTruck03/Documentation/SixWheelTruck03Controller-Speedometer-Documentation.txt


* SixWheelTruck04 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/SixWheelTruck/SixWheelTruck04/Documentation/SixWheelTruck04Controller-Only-Documentation.txt


* SixWheelTruck04 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/SixWheelTruck/SixWheelTruck04/Documentation/SixWheelTruck04Controller-Speedometer-Documentation.txt


* SixWheelTruck04 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/SixWheelTruck/SixWheelTruck04/Documentation/SixWheelTruck04Controller-wEntry-Documentation.txt


* SixWheelTruck04 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/SixWheelTruck/SixWheelTruck04/Documentation/SixWheelTruck04Controller-Speedometer-Documentation.txt


* SixWheelTruck05 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/SixWheelTruck/SixWheelTruck05/Documentation/SixWheelTruck05Controller-Only-Documentation.txt


* SixWheelTruck05 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/SixWheelTruck/SixWheelTruck05/Documentation/SixWheelTruck05Controller-Speedometer-Documentation.txt


* SixWheelTruck05 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/SixWheelTruck/SixWheelTruck05/Documentation/SixWheelTruck05Controller-wEntry-Documentation.txt


* SixWheelTruck05 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/SixWheelTruck/SixWheelTruck05/Documentation/SixWheelTruck05Controller-Speedometer-Documentation.txt


* SixWheelTruck06 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/SixWheelTruck/SixWheelTruck06/Documentation/SixWheelTruck06Controller-Only-Documentation.txt


* SixWheelTruck06 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/SixWheelTruck/SixWheelTruck06/Documentation/SixWheelTruck06Controller-Speedometer-Documentation.txt


* SixWheelTruck06 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/SixWheelTruck/SixWheelTruck06/Documentation/SixWheelTruck06Controller-wEntry-Documentation.txt


* SixWheelTruck06 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/SixWheelTruck/SixWheelTruck06/Documentation/SixWheelTruck06Controller-Speedometer-Documentation.txt


* All SixWheelTruck(s) in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/SixWheelTruck/Documentation/AllSixWheelTruckControllers-wEntry-Documentation.txt



Sedan: (total: 6)
--------------------------


* Sedan01 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/Sedan/Sedan01/Documentation/Sedan01Controller-Only-Documentation.txt


* Sedan01 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/Sedan/Sedan01/Documentation/Sedan01Controller-Speedometer-Documentation.txt


* Sedan01 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/Sedan/Sedan01/Documentation/Sedan01Controller-wEntry-Documentation.txt


* Sedan01 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/Sedan/Sedan01/Documentation/Sedan01Controller-Speedometer-Documentation.txt


* Sedan02 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/Sedan/Sedan02/Documentation/Sedan02Controller-Only-Documentation.txt


* Sedan02 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/Sedan/Sedan02/Documentation/Sedan02Controller-Speedometer-Documentation.txt


* Sedan02 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/Sedan/Sedan02/Documentation/Sedan02Controller-wEntry-Documentation.txt


* Sedan02 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/Sedan/Sedan02/Documentation/Sedan02Controller-Speedometer-Documentation.txt


* Sedan03 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/Sedan/Sedan03/Documentation/Sedan03Controller-Only-Documentation.txt


* Sedan03 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/Sedan/Sedan03/Documentation/Sedan03Controller-Speedometer-Documentation.txt


* Sedan03 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/Sedan/Sedan03/Documentation/Sedan03Controller-wEntry-Documentation.txt


* Sedan03 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/Sedan/Sedan03/Documentation/Sedan03Controller-Speedometer-Documentation.txt


* Sedan04 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/Sedan/Sedan04/Documentation/Sedan04Controller-Only-Documentation.txt


* Sedan04 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/Sedan/Sedan04/Documentation/Sedan04Controller-Speedometer-Documentation.txt


* Sedan04 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/Sedan/Sedan04/Documentation/Sedan04Controller-wEntry-Documentation.txt


* Sedan04 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/Sedan/Sedan04/Documentation/Sedan04Controller-Speedometer-Documentation.txt


* Sedan05 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/Sedan/Sedan05/Documentation/Sedan05Controller-Only-Documentation.txt


* Sedan05 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/Sedan/Sedan05/Documentation/Sedan05Controller-Speedometer-Documentation.txt


* Sedan05 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/Sedan/Sedan05/Documentation/Sedan05Controller-wEntry-Documentation.txt


* Sedan05 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/Sedan/Sedan05/Documentation/Sedan05Controller-Speedometer-Documentation.txt


* Sedan06 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/Sedan/Sedan06/Documentation/Sedan06Controller-Only-Documentation.txt


* Sedan06 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/Sedan/Sedan06/Documentation/Sedan06Controller-Speedometer-Documentation.txt


* Sedan06 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/Sedan/Sedan06/Documentation/Sedan06Controller-wEntry-Documentation.txt


* Sedan06 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/Sedan/Sedan06/Documentation/Sedan06Controller-Speedometer-Documentation.txt


* All Sedan(s) in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/Sedan/Documentation/AllSedanControllers-wEntry-Documentation.txt



Tank RU: (total: 6)
--------------------------


* TankRU01 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/TankRU/TankRU01/Documentation/TankRU01Controller-Only-Documentation.txt


* TankRU01 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/TankRU/TankRU01/Documentation/TankRU01Controller-Speedometer-Documentation.txt


* TankRU01 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/TankRU/TankRU01/Documentation/TankRU01Controller-Only-wEntry-Documentation.txt


* TankRU01 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/TankRU/TankRU01/Documentation/TankRU01Controller-Speedometer-Documentation.txt


* TankRU02 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/TankRU/TankRU02/Documentation/TankRU02Controller-Only-Documentation.txt


* TankRU02 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/TankRU/TankRU02/Documentation/TankRU02Controller-Speedometer-Documentation.txt


* TankRU02 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/TankRU/TankRU02/Documentation/TankRU02Controller-Only-wEntry-Documentation.txt


* TankRU02 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/TankRU/TankRU02/Documentation/TankRU02Controller-Speedometer-Documentation.txt


* TankRU03 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/TankRU/TankRU03/Documentation/TankRU03Controller-Only-Documentation.txt


* TankRU03 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/TankRU/TankRU03/Documentation/TankRU03Controller-Speedometer-Documentation.txt


* TankRU03 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/TankRU/TankRU03/Documentation/TankRU03Controller-Only-wEntry-Documentation.txt


* TankRU03 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/TankRU/TankRU03/Documentation/TankRU03Controller-Speedometer-Documentation.txt


* TankRU04 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/TankRU/TankRU04/Documentation/TankRU04Controller-Only-Documentation.txt


* TankRU04 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/TankRU/TankRU04/Documentation/TankRU04Controller-Speedometer-Documentation.txt


* TankRU04 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/TankRU/TankRU04/Documentation/TankRU04Controller-Only-wEntry-Documentation.txt


* TankRU04 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/TankRU/TankRU04/Documentation/TankRU04Controller-Speedometer-Documentation.txt


* TankRU05 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/TankRU/TankRU05/Documentation/TankRU05Controller-Only-Documentation.txt


* TankRU05 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/TankRU/TankRU05/Documentation/TankRU05Controller-Speedometer-Documentation.txt


* TankRU05 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/TankRU/TankRU01/Documentation/TankRU01Controller-Only-wEntry-Documentation.txt


* TankRU05 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/TankRU/TankRU05/Documentation/TankRU05Controller-Speedometer-Documentation.txt


* TankRU06 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/TankRU/TankRU06/Documentation/TankRU06Controller-Only-Documentation.txt


* TankRU06 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/TankRU/TankRU06/Documentation/TankRU06Controller-Speedometer-Documentation.txt


* TankRU06 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/TankRU/TankRU06/Documentation/TankRU06Controller-Only-wEntry-Documentation.txt


* TankRU06 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/TankRU/TankRU06/Documentation/TankRU06Controller-Speedometer-Documentation.txt


* All TankRU(s) in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/TankRU/Documentation/AllTankRUControllers-wEntry-Documentation.txt



Tank US: (total: 6)
--------------------------


* TankUS01 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/TankUS/TankUS01/Documentation/TankUS01Controller-Only-Documentation.txt


* TankUS01 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/TankUS/TankUS01/Documentation/TankUS01Controller-Speedometer-Documentation.txt


* TankUS01 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/TankUS/TankUS01/Documentation/TankUS01Controller-Only-wEntry-Documentation.txt


* TankUS01 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/TankUS/TankUS01/Documentation/TankUS01Controller-Speedometer-Documentation.txt


* TankUS02 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/TankUS/TankUS02/Documentation/TankUS02Controller-Only-Documentation.txt


* TankUS02 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/TankUS/TankUS02/Documentation/TankUS02Controller-Speedometer-Documentation.txt


* TankUS02 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/TankUS/TankUS02/Documentation/TankUS02Controller-Only-wEntry-Documentation.txt


* TankUS02 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/TankUS/TankUS02/Documentation/TankUS02Controller-Speedometer-Documentation.txt


* TankUS03 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/TankUS/TankUS03/Documentation/TankUS03Controller-Only-Documentation.txt


* TankUS03 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/TankUS/TankUS03/Documentation/TankUS03Controller-Speedometer-Documentation.txt


* TankUS03 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/TankUS/TankUS03/Documentation/TankUS03Controller-Only-wEntry-Documentation.txt


* TankUS03 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/TankUS/TankUS03/Documentation/TankUS03Controller-Speedometer-Documentation.txt


* TankUS04 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/TankUS/TankUS04/Documentation/TankUS04Controller-Only-Documentation.txt


* TankUS04 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/TankUS/TankUS04/Documentation/TankUS04Controller-Speedometer-Documentation.txt


* TankUS04 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/TankUS/TankUS04/Documentation/TankUS04Controller-Only-wEntry-Documentation.txt


* TankUS04 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/TankUS/TankUS04/Documentation/TankUS04Controller-Speedometer-Documentation.txt


* TankUS05 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/TankUS/TankUS05/Documentation/TankUS05Controller-Only-Documentation.txt


* TankUS05 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/TankUS/TankUS05/Documentation/TankUS05Controller-Speedometer-Documentation.txt


* TankUS05 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/TankUS/TankUS05/Documentation/TankUS05Controller-Only-wEntry-Documentation.txt


* TankUS05 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/TankUS/TankUS05/Documentation/TankUS05Controller-Speedometer-Documentation.txt


* TankUS06 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/TankUS/TankUS06/Documentation/TankUS06Controller-Only-Documentation.txt


* TankUS06 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Extras/VehicleController-Only-Usage/Vehicle-Speedometer/Assets/VehiclesControl/TankUS/TankUS06/Documentation/TankUS06Controller-Speedometer-Documentation.txt


* TankUS06 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/TankUS/TankUS06/Documentation/TankUS06Controller-Only-wEntry-Documentation.txt


* TankUS06 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/TankUS/TankUS06/Documentation/TankUS06Controller-Speedometer-Documentation.txt


* All TankUS(s) in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Unity-6/Assets/VehiclesControl/TankUS/Documentation/AllTankUSControllers-wEntry-Documentation.txt

