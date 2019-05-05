/* This code is provided for educational purposes only. Use at your own risk.
   Downloaded from http://keinplatz.spaces.live.com
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Sidebar
{
    /// <summary>
    /// Source http://vbnet.mvps.org/index.html?code/browse/csidlvalues.htm
    /// </summary>
    class ShellEnums
    {
        #region CSIDL
        /*
Shell and Common Controls Versions 
 

All but a handful of the programming elements discussed in the shell and common controls documentation are contained in three DLLs: Comctl32.dll, Shell32.dll, and Shlwapi.dll. Because of ongoing enhancements, different versions of these DLLs implement different features. Throughout this document, programming elements are marked with a version number. This version number indicates that the programming element was first implemented in that version and will also be found in all subsequent versions of the DLL. If no version number is specified, the programming element is implemented in all versions. The following table outlines the different DLL versions, and how they were distributed.

Version  DLL  Distribution Platform 
4.00  All  Microsoft® Windows® 95/Windows NT® 4.0. 
4.70  All  Microsoft® Internet Explorer 3.x. 
4.71  All  Microsoft® Internet Explorer 4.0 (see note 2). 
4.72  All  Microsoft® Internet Explorer 4.01 and Windows® 98 (see note 2). 
5.00  Shlwapi.dll  Microsoft® Internet Explorer 5 (see note 3). 
5.00  Shell32.dll  Microsoft® Windows® 2000. (see note 3). 
5.80  Comctl32.dll  Microsoft® Internet Explorer 5 (see note 3). 
5.81  Comctl32.dll  Microsoft® Windows 2000 and Windows ME (see note 3). 
6.00   Comctl32.dll   Microsoft® Windows XP. See note 4. 

Note 1: 
The 4.00 versions of Shell32.dll and Comctl32.dll are found on the original versions of Windows 95 and Windows NT 4. New versions of Commctl.dll were shipped with all Internet Explorer releases. Shlwapi.dll first shipped with Internet Explorer 4.0, so its first version number is 4.71. The Shell was not updated with the Internet Explorer 3.0 release, so Shell32.dll does not have a version 4.70. While Shell32.dll versions 4.71 and 4.72 were shipped with the corresponding Internet Explorer releases, they were not necessarily installed (see note 2). For subsequent releases, the version numbers for the three DLLs are not identical. In general, you should assume that all three DLLs may have different version numbers, and test each one separately.

Note 2:
All systems with Internet Explorer 4.0 or 4.01 will have the associated version of Comctl32.dll and Shlwapi.dll (4.71 or 4.72, respectively). However, for systems prior to Windows 98, Internet Explorer 4.0 and 4.01 can be installed with or without the integrated Shell. If they are installed with the integrated Shell, the associated version of Shell32.dll will be installed. If they are installed without the integrated Shell, Shell32.dll is not updated. In other words, the presence of version 4.71 or 4.72 of Comctl32.dll or Shlwapi.dll on a system does not guarantee that Shell32.dll has the same version number. All Windows 98 systems have version 4.72 of Shell32.dll.

Note 3:
Version 5.80 of Comctl32.dll and version 5.0 of Shlwapi.dll are distributed with Internet Explorer 5. They will be found on all systems on which Internet Explorer 5 is installed, except Windows 2000. Internet Explorer 5 does not update the Shell, so version 5.0 of Shell32.dll will not be found on Windows NT, Windows 95, or Windows 98 systems. Version 5.0 of Shell32.dll will be distributed with Windows 2000 and Windows Me, along with version 5.0 of Shlwapi.dll, and version 5.81 of Comctl32.dll.

Note 4:
ComCtl32.dll version 6 is not redistributable. If you want your application to use ComCtl32.dll version 6, you must add an application manifest that indicates that version 6 should be used if it is available.

 

 CSIDL Values 
 

Applications frequently use a number of folders which might not have the same name or location on any given system. For example, the system folder might be called C:\Windows on one system and C:\Winnt on another. CSIDL values provide a unique system-independent way to identify these special folders. The values supersede the use of environment variables for this purpose. 

You use a CSIDL in conjunction with one of four Shell functions, SHGetFolderLocation, SHGetFolderPath, SHGetSpecialFolderLocation, and SHGetSpecialFolderPath, to retrieve a special folder's path name or pointer to an item identifier list (PIDL) .

Most CSIDLs correspond to either file system folders or virtual folders. Where the CSIDL identifies a file system folder, a commonly used path is given as an example. Other paths can be used. Some CSIDLs can be mapped to an equivalent %VariableName% environment variable. CSIDLs are more reliable, however, and should be used if possible. 

Note that some constants represent non-file system elements (e.g. Drives, Nethood) which are part of Windows explorer namespace. These elements do not return file system paths and so may not return a value to the textbox when selected.


--------------------------------------------------------------------------------
*/
        internal enum CSIDLValues
        {
            CSIDL_INVALID = 0xFFFF,
            CSIDL_DESKTOP = 0x0000,
            CSIDL_INTERNET = 0x0001,
            CSIDL_PROGRAMS = 0x0002,
            CSIDL_CONTROLS = 0x0003,
            CSIDL_PRINTERS = 0x0004,
            CSIDL_PERSONAL = 0x0005,
            CSIDL_FAVORITES = 0x0006,
            CSIDL_STARTUP = 0x0007,
            CSIDL_RECENT = 0x0008,
            CSIDL_SENDTO = 0x0009,
            CSIDL_BITBUCKET = 0x000A,
            CSIDL_STARTMENU = 0x000B,
            CSIDL_MYDOCUMENTS = 0x000C,
            CSIDL_MYMUSIC = 0x000D,
            CSIDL_MYVIDEO = 0x000E,
            CSIDL_DIRECTORY = 0x0010,
            CSIDL_DRIVES = 0x0011,
            CSIDL_NETWORK = 0x0012,
            CSIDL_NETHOOD = 0x0013,
            CSIDL_FONTS = 0x0014,
            CSIDL_TEMPLATES = 0x0015,
            CSIDL_COMMON_STARTMENU = 0x016,
            CSIDL_COMMON_PROGRAMS = 0x0017,
            CSIDL_COMMON_STARTUP = 0x0018,
            CSIDL_COMMON_DESKTOPDIRECTORY = 0x0019,
            CSIDL_APPDATA = 0x001A,
            CSIDL_PRINTHOOD = 0x001B,
            CSIDL_LOCAL_APPDATA = 0x001C,
            CSIDL_ALTSTARTUP = 0x001D,
            CSIDL_COMMON_ALTSTARTUP = 0x001E,
            CSIDL_COMMON_FAVORITES = 0x001F,
            CSIDL_INTERNET_CACHE = 0x0020,
            CSIDL_COOKIES = 0x0021,
            CSIDL_HISTORY = 0x0022,
            CSIDL_COMMON_APPDATA = 0x0023,
            CSIDL_WINDOWS = 0x0024,
            CSIDL_SYSTEM = 0x0025,
            CSIDL_PROGRAM_FILES = 0x0026,
            CSIDL_MYPICTURES = 0x0027,
            CSIDL_PROFILE = 0x0028,
            CSIDL_SYSTEMX86 = 0x0029,
            CSIDL_PROGRAM_FILESX86 = 0x002A,
            CSIDL_PROGRAM_FILES_COMMON = 0x002B,
            CSIDL_PROGRAM_FILES_COMMONX86 = 0x002C,
            CSIDL_COMMON_TEMPLATES = 0x002D,
            CSIDL_COMMON_DOCUMENTS = 0x002E,
            CSIDL_COMMON_ADMINTOOLS = 0x002F,
            CSIDL_ADMINTOOLS = 0x0030,
            CSIDL_CONNECTIONS = 0x0031,
            CSIDL_COMMON_MUSIC = 0x0035,
            CSIDL_COMMON_PICTURES = 0x0036,
            CSIDL_COMMON_VIDEO = 0x0037,
            CSIDL_RESOURCES = 0x0038,
            CSIDL_RESOURCES_LOCALIZED = 0x0039,
            CSIDL_COMMON_OEM_LINKS = 0x003A,
            CSIDL_CDBURN_AREA = 0x003B,
            CSIDL_COMPUTERSNEARME = 0x003D,
            CSIDL_FLAG_PER_USER_INIT = 0x0800,
            CSIDL_FLAG_NO_ALIAS = 0x1000,
            CSIDL_FLAG_DONT_VERIFY = 0x4000,
            CSIDL_FLAG_CREATE = 0x8000,
            CSIDL_FLAG_MASK = 0xFF00
        }
        /*
Constants

CSIDL_DESKTOP 
Windows desktop—virtual folder that is the root of the name space. 
  
CSIDL_INTERNET 
Virtual folder that represents the Internet. 
  
CSIDL_PROGRAMS 
File system directory that contains the user's program groups (which are also file system directories). A typical path is C:\Documents and Settings\username\Start Menu\Programs. 
  
CSIDL_CONTROLS 
Virtual folder that contains icons for Control Panel applications. 
  
CSIDL_PRINTERS 
Virtual folder that contains installed printers. 
  
CSIDL_PERSONAL 
File system directory that serves as a common repository for documents. A typical path is C:\Documents and Settings\username\My Documents. This is different from the My Documents virtual folder in the name space. To access that virtual folder, use the technique described in Managing the File System. 
  
CSIDL_FAVORITES 
File system directory that serves as a common repository for the user's favourite items. A typical path is C:\Documents and Settings\username\Favorites. 
  
CSIDL_STARTUP 
File system directory that corresponds to the user's Startup program group. The system starts these programs whenever any user logs onto Microsoft® Windows NT® or starts Microsoft® Windows® 98. A typical path is C:\Documents and Settings\username\Start Menu\Programs\Startup. 
  
CSIDL_RECENT 
File system directory that contains the user's most recently used documents. A typical path is C:\Documents and Settings\username\Recent. To create a shortcut in this folder, use SHAddToRecentDocs. In addition to creating the shortcut, this function updates the Shell's list of recent documents and adds the shortcut to the Documents submenu of the Start menu. 
  
CSIDL_SENDTO 
File system directory that contains Send To menu items. A typical path is C:\Documents and Settings\username\SendTo. 
  
CSIDL_BITBUCKET 
Virtual folder that contains the objects in the user's Recycle Bin. 
  
CSIDL_STARTMENU 
File system directory that contains Start Menu items. A typical path is C:\Documents and Settings\username\Start Menu. 
  
CSIDL_MYDOCUMENTS 
Virtual folder that contains the objects in the user's My Documents folder. 
  
CSIDL_MYMUSIC 
File system directory that serves as a common repository for music files. A typical path is C:\My Music. 
  
CSIDL_MYVIDEO 
File system directory that serves as a common repository for video files. 
  
CSIDL_DIRECTORY 
File system directory used to physically store file objects on the desktop (not to be confused with the desktop folder itself). A typical path is C:\Documents and Settings\username\Desktop 
  
CSIDL_DRIVES 
My Computer—virtual folder that contains everything on the local computer: storage devices, printers, and Control Panel. The folder can also contain mapped network drives. 
  
CSIDL_NETWORK 
Network Neighborhood—virtual folder that represents the root of the network namespace hierarchy. 
  
CSIDL_NETHOOD 
A file system folder that contains the link objects that can exist in the My Network Places virtual folder. It is not the same as CSIDL_NETWORK, which represents the network namespace root. A typical path is C:\Documents and Settings\username\NetHood. 
  
CSIDL_FONTS 
Virtual folder that contains fonts. A typical path is C:\WINNT\Fonts. 
  
CSIDL_TEMPLATES 
File system directory that serves as a common repository for document templates. 
  
CSIDL_COMMON_STARTMENU 
File system directory that contains the programs and folders that appear on the Start Menu for all users. A typical path is C:\Documents and Settings\All Users\Start Menu. Valid only for Windows NT systems. 
  
CSIDL_COMMON_PROGRAMS 
File system directory that contains the directories for the common program groups that appear in the Start Menu for all users. A typical path is C:\Documents and Settings\All Users\Start Menu\Programs. Valid only for Windows NT systems. 
  
CSIDL_COMMON_STARTUP 
File system directory that contains the programs that appear in the Startup folder for all users. A typical path is C:\Documents and Settings\All Users\Start Menu\Programs\Startup. Valid only for Windows NT systems. 
  
CSIDL_COMMON_DESKTOPDIRECTORY 
File system directory that contains files and folders that appear on the desktop for all users. A typical path is C:\Documents and Settings\All Users\Desktop. Valid only for Windows NT systems. 
  
CSIDL_APPDATA 
Version 4.71. File system directory that serves as a common repository for application-specific data. A typical path is C:\Documents and Settings\username\Application Data. This CSIDL is supported by the redistributable ShFolder.dll for systems that do not have the Microsoft® Internet Explorer 4.0 integrated Shell installed. 
  
CSIDL_PRINTHOOD 
File system directory that contains the link objects that can exist in the Printers virtual folder. A typical path is C:\Documents and Settings\username\PrintHood. 
  
CSIDL_LOCAL_APPDATA 
Version 5.0. File system directory that serves as a data repository for local (non-roaming) applications. A typical path is C:\Documents and Settings\username\Local Settings\Application Data. 
  
CSIDL_ALTSTARTUP 
File system directory that corresponds to the user's non-localized Startup program group. 
  
CSIDL_COMMON_ALTSTARTUP 
File system directory that corresponds to the non-localized Startup program group for all users. Valid only for Windows NT systems. 
  
CSIDL_COMMON_FAVORITES 
File system directory that serves as a common repository for all user's favourite items. Valid only for Windows NT systems. 
  
CSIDL_INTERNET_CACHE 
Version 4.72. File system directory that serves as a common repository for temporary Internet files. A typical path is C:\Documents and Settings\username\Temporary Internet Files. 
  
CSIDL_COOKIES 
File system directory that serves as a common repository for Internet cookies. A typical path is C:\Documents and Settings\username\Cookies. 
  
CSIDL_HISTORY 
File system directory that serves as a common repository for Internet history items. 
  
CSIDL_COMMON_APPDATA 
Version 5.0. Application data for all users. A typical path is C:\Documents and Settings\All Users\Application Data. 
  
CSIDL_WINDOWS 
Version 5.0. Windows directory or SYSROOT. This corresponds to the %windir% or %SYSTEMROOT% environment variables. A typical path is C:\WINNT. 
  
CSIDL_SYSTEM 
Version 5.0. System folder. A typical path is C:\WINNT\SYSTEM32. 
  
CSIDL_PROGRAM_FILES 
Version 5.0. Program Files folder. A typical path is C:\Program Files. 
  
CSIDL_MYPICTURES 
Version 5.0. My Pictures folder. A typical path is C:\Documents and Settings\username\My Documents\My Pictures. 
  
CSIDL_PROFILE 
Version 5.0. User's profile folder. 
  
CSIDL_SYSTEMX86 
The x86 system directory on Reduced Instruction Set Computer (RISC) systems. 
  
CSIDL_PROGRAM_FILESX86 
The x86 Program Files folder on RISC systems. 
  
CSIDL_PROGRAM_FILES_COMMON 
Version 5.0. A folder for components that are shared across applications. A typical path is C:\Program Files\Common. Valid only for Windows NT and Windows 2000 systems. 
  
CSIDL_PROGRAM_FILES_COMMONX86 
The x86 Program Files Common folder on RISC systems. 
  
CSIDL_COMMON_TEMPLATES 
File system directory that contains the templates that are available to all users. A typical path is C:\Documents and Settings\All Users\Templates. Valid only for Windows NT systems. 
  
CSIDL_COMMON_DOCUMENTS 
File system directory that contains documents that are common to all users. Typical paths are C:\Documents and Settings\All Users\Documents. Valid for Windows NT systems and Windows 95 and Windows 98 systems with Shfolder.dll installed. 
  
CSIDL_COMMON_ADMINTOOLS 
Version 5.0. File system directory that contains administrative tools for all users. 
  
CSIDL_ADMINTOOLS 
Version 5.0. File system directory used to store administrative tools for an individual user. The Microsoft Management Console (MMC) saves customized consoles to this directory, and it roams with the user. 
  
CSIDL_CONNECTIONS 
Virtual folder that contains network and dial-up connections. 
  
CSIDL_COMMON_MUSIC 
My Music folder for all users. For more information, see CSIDL_MYMUSIC. 
  
CSIDL_COMMON_PICTURES 
My Pictures folder for all users. For more information, see CSIDL_MYPICTURES. 
  
CSIDL_COMMON_VIDEO 
My Video folder for all users. For more information, see CSIDL_MYVIDEO. 
  
CSIDL_RESOURCES 
System resource directory. A typical path is C:\WINNT\Resources. 
  
CSIDL_RESOURCES_LOCALIZED 
Localized resource directory. For more information, see CSIDL_RESOURCES. 
  
CSIDL_COMMON_OEM_LINKS 
Folder containing links to OEM specific applications for all users. 
  
CSIDL_CDBURN_AREA 
File system folder used to hold data for burning to a CD. Typically [User Profile Folder]\Local Settings\Applications Data\Microsoft\CD Burning. 
  
CSIDL_COMPUTERSNEARME 
Computers Near Me folder. Virtual folder that contains links to nearby computers on the network. Nearness it is established by common work group membership. 
  
CSIDL_FLAG_PER_USER_INIT 
Combine this flag with the desired CSIDL_ value to indicate per-user initialization. 
  
CSIDL_FLAG_NO_ALIAS 
Combine this flag with the desired CSIDL_ value to force a non-alias version of the PIDL. 
  
CSIDL_FLAG_DONT_VERIFY 
Combine this flag with the desired CSIDL_ value to return an unverified folder path. 
  
CSIDL_FLAG_CREATE 
Combine this flag with the desired CSIDL_ value to force the creation of the associated folder. 
  
CSIDL_FLAG_MASK 
Mask for all possible CSIDL flag values. 
          */
        #endregion

        #region FOLDERVIEWMODE
        internal enum FOLDERVIEWMODE
        {
            FVM_FIRST = 1,
            FVM_ICON = 1,
            FVM_SMALLICON = 2,
            FVM_LIST = 3,
            FVM_DETAILS = 4,
            FVM_THUMBNAIL = 5,
            FVM_TILE = 6,
            FVM_THUMBSTRIP = 7,
            FVM_LAST = 7
        }
        /*
        Constants

        FVM_FIRST
        Specifies a convenience constant equal to the first constant in FOLDERVIEWMODE.

        FVM_ICON
        The view should display medium-size icons. 

        FVM_SMALLICON
        The view should display small icons. 

        FVM_LIST
        Object names are displayed in a list view.

        FVM_DETAILS
        Object names and other selected information, such as the size or date last updated, are shown.

        FVM_THUMBNAIL
        The view should display thumbnail icons. 

        FVM_TILE
        The view should display large icons. 

        FVM_THUMBSTRIP
        The view should display icons in a filmstrip format.

        FVM_LAST
        Specifies a convenience constant equal to the last constant in FOLDERVIEWMODE.
        */
        #endregion
    }
}
