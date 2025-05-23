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


NOTE: This project was developed while / for using Unity 2021+ & 2022+ & Unity 6


Old_Input_System Directory NOTE:

Provided variants: ( 2021+ / 2022+ variant & Unity 6+ variant )

NOTE: These currently still use the "Old Input System", so as such depending on what version of Unity you may be using it may be necessary to make sure such or both is enabled in project settings.


New_Input_System Variant Directory NOTE:

Provided variants: ( 2021+ / 2022+ variant & Unity 6+ variant )


NOTE: This currently uses the "New Input System", so as such depending on what version of Unity you may be using it may be necessary to make sure such or both is enabled in project settings.


New Input System Documentations NOTE: Currently the included documentations are from the old files that still need editing to reflect any changes in setup for new input usages, as such there are many files to edit thus it will be time consuming and will be completed if and or when limited free time allows. In the meantime one can simply ignore any parts related to input customizations and then refer to Input Actions mentioned below for now...


New_Input_System Directory Documentations NOTE: If there is any confusion with any documentation during setup in regards to "Input Actions", just note the following "Input Action Assets" found below:

For player:

Input Actions:

Player Controls: PlayerControls (Input Action Asset)

For vehicles:

Input Actions:

Car Controls: CarControls (Input Action Asset)

Tank Controls: TankControls (Input Action Asset)



Vehicles Currently "Completed" & Included: (total: 42)
------------------------------------------------------


* Armored Truck (100% completed) (total: 6)
* Dune Buggy (100% completed) (total: 6)
* Humvee (100% completed) (total: 6)
* Six Wheel Truck (100% completed) (total: 6)
* Sedan (100% completed) (total: 6)
* Tank RU (100% completed) (total: 6)
* Tank US (100% completed) (total: 6)



Other Currently "Completed" & Included:
---------------------------------------


* Player & Vehicles Compass


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


Old_Input_System:


* Player Forward:   W
* Player Reverse:   S
* Player Left:      A
* Player Right:     D
* Player Jump:      Space
* Player Sprint:    Left Shift


New_Input_System:


* Player Forward:   W [Keyboard] / Left Stick [Gamepad]
* Player Reverse:   S [Keyboard] / Left Stick [Gamepad]
* Player Left:      A [Keyboard] / Left Stick [Gamepad]
* Player Right:     D [Keyboard] / Left Stick [Gamepad]
* Player Jump:      Space [Keyboard] / Button South [Gamepad] 
* Player Sprint:    Shift [Keyboard] / Left Shoulder [Gamepad]
* Player Look:      Delta [Mouse] / Right Stick [Gamepad]


Vehicle Controls: 
-----------------


  Note: The following below are related to both variations either standalone vehicle controller usage and entry script usage.


Old_Input_System:


* Vehicle Forward:  W
* Vehicle Reverse:  S
* Turn Left:        A
* Turn Right:       D
* Apply Brake:      Space


New_Input_System:


* Vehicle Forward:   W [Keyboard] / Left Stick [Gamepad]
* Vehicle Reverse:   S [Keyboard] / Left Stick [Gamepad]
* Vehicle Left:      A [Keyboard] / Left Stick [Gamepad]
* Vehicle Right:     D [Keyboard] / Left Stick [Gamepad]
* Vehicle Brake:     Space [Keyboard] / Right Trigger [Gamepad] 


Entry Script: 


  Note: The following found below are specific only when entry script is applied.


Old_Input_System:


* Enter Vehicle:    E
* Exit Vehicle:     F


New_Input_System:


* Enter Vehicle:      E [Keyboard] / Button North [Gamepad] 
* Exit Vehicle:       F [Keyboard] / Button South [Gamepad] 


Note: Additional specific only to Tanks US & RU are the following controls specific to the tank turret and tank barrel movements:


Old_Input_System:


* Mouse X 
* Mouse Y


New_Input_System:


* Turret & Barrel: Delta [Mouse] / Right Stick [Gamepad]



Manual Setup Instruction:
-------------------------


Simply follow the linkages found below  for documentation information / instruction respective to the version say for example either Unity 2021+ & Unity 2022+ or Unity 6....


Old_Input_System Variants:


* Unity 2021+ & 2022+ => Files, ReadMe, docs: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/tree/main/Old_Input_System/Unity-2021-2022


* Unity 6 => Files, ReadMe, docs: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/Old_Input_System/Unity-6



New_Input_System Variants:


* Unity 2021+ & 2022+ => Files, ReadMe, docs: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/tree/main/New_Input_System/Unity-2021-2022


* Unity 6 => Files, ReadMe, docs: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyBR/blob/main/New_Input_System/Unity-6


