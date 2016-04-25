.PHONY: zip.clean	
	
zip: 
	zip -r IVS WindowsFormsApplication2

clean:
	rm -rf  WindowsFormsApplication2/ClassLibrary1/ClassLibrary1/obj
	rm -rf  WindowsFormsApplication2/ClassLibrary1/ClassLibrary1/Properties
	rm -rf  WindowsFormsApplication2/WindowsFormsApplication2/obj
	rm -rf  WindowsFormsApplication2/WindowsFormsApplication2/Properties
	rm -rf  WindowsFormsApplication2/WindowsFormsApplication2/bin/Debug/WindowsFormsApplication2.exe.config
	rm -rf  WindowsFormsApplication2/WindowsFormsApplication2/bin/Debug/WindowsFormsApplication2.pdb	
	rm -rf  WindowsFormsApplication2/WindowsFormsApplication2/bin/Debug/WindowsFormsApplication2.vshost.exe
	rm -rf  WindowsFormsApplication2/WindowsFormsApplication2/bin/Debug/WindowsFormsApplication2.vshost.exe.config
	rm -rf  WindowsFormsApplication2/WindowsFormsApplication2/bin/Debug/WindowsFormsApplication2.vshost.exe.manifest
 
	


