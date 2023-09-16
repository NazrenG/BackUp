
using BackUp.Class;

Dvd dvd = new Dvd("Dvd-R", "model_12");
dvd.Capacity();
dvd.FreeMemory();
dvd.Copy();
dvd.PrintDeviceİnfo();

Flash flash = new Flash("SanDisk", "model_1");
flash.Capacity();
flash.FreeMemory();
flash.Copy();
flash.PrintDeviceİnfo();

Hdd hdd = new Hdd("WDblue", "model_22");
hdd.Capacity();
hdd.FreeMemory();
hdd.Copy();
hdd.PrintDeviceİnfo();