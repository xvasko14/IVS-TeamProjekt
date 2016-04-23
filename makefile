.PHONY: zip.clean

SUBDIRS := $(wildcard */)
ZIPS := $(addsuffix .zip,$(subst /,,$(SUBDIRS)))

$(ZIPS) : %.zip : | %
	zip -r IVS-TeamProjekt-master.zip team
	
	
zip: $(ZIPS)

clean:
	rm -rf -v team/WindowsFormsApplication2/ClassLibrary1/ClassLibrary1/obj
	rm -rf -v team/WindowsFormsApplication2/ClassLibrary1/ClassLibrary1/Properties
	rm -rf -v team/WindowsFormsApplication2/WindowsFormsApplication2/obj
	rm -rf -v team/WindowsFormsApplication2/WindowsFormsApplication2/Properties
	rm -rf -v team/WindowsFormsApplication2/WindowsFormsApplication2/bin/Debug/WindowsFormsApplication2.exe.config
	rm -rf -v team/WindowsFormsApplication2/WindowsFormsApplication2/bin/Debug/WindowsFormsApplication2.pdb	
	rm -rf -v team/WindowsFormsApplication2/WindowsFormsApplication2/bin/Debug/WindowsFormsApplication2.vshost.exe
	rm -rf -v team/WindowsFormsApplication2/WindowsFormsApplication2/bin/Debug/WindowsFormsApplication2.vshost.exe.config
	rm -rf -v team/WindowsFormsApplication2/WindowsFormsApplication2/bin/Debug/WindowsFormsApplication2.vshost.exe.manifest
 
	


