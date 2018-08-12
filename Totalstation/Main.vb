Imports System.Threading
Imports System.Speech
Imports System.Windows.Forms

Public Class Main
    Dim int As Integer = 0
    Dim door As Boolean = True
    Dim pin As String
    Dim rightchoice As String
    Dim nmm As Integer
    Dim Bp As New AudioFile(Application.StartupPath & "\Beep.mp3")
    Dim audio As New AudioFile("C:\Users\Ihab-majdy\Desktop\meas.mp3")
    Dim n As String
    Dim m As Integer = 1
    Dim buttonPressed As Boolean
    Dim im As Integer = 1
    Dim swth2, swth3 As Integer
    Dim swth1 As Integer = 1
    Dim change As Boolean = True
    Dim gh As Integer = 0
    '0000000000000000000000000000000000000000
    'Page 70,71,74,75,76,77,78,80
    'Page 82,83,84,85,86,93>>>Stoped on 94 Contaun
    'Page 268 >>> Check on total station Device
    'Page 
    '0000000000000000000000000000000000000000
    ' Dim sapi = CreateObject("sapi.spvoice")
    Sub ff(ByVal nm As Integer)
        'form 1 to 100
        ListBox1.Items.Clear()
        nmm = nm
        '###################### Face Page #################
        If nm = 100 Then
            ListBox1.Items.Add("CX - 101           rec10000")
            ListBox1.Items.Add(" S/N  000000")
            ListBox1.Items.Add("  Ver . 103EN")
            ListBox1.Items.Add("           1.0")
            ListBox1.Items.Add("      JOB.JOB" & im)
            ListBox1.Items.Add("OBS    USB   DATA   CNFG")

            Shortcutexp.RichTextBox1.Text = "ذاكرة التسجيل    واسم الجهاز" & vbCrLf
            Shortcutexp.RichTextBox1.AppendText("تطبيقات الجهاز" & vbCrLf)
            Shortcutexp.RichTextBox1.AppendText("اصدارات البرماجيات على الجهاز" & vbCrLf)
            Shortcutexp.RichTextBox1.AppendText("رقم النسخة" & vbCrLf)
        End If
        If nm = 101 Then
            Dim te As System.DateTime = System.DateTime.Now


            ListBox1.Items.Add("CX - 101           rec10000")
            ListBox1.Items.Add(" S/N  000000")
            ListBox1.Items.Add("Date      " & te.ToString("MMM. dd, yyyy"))
            ListBox1.Items.Add("Time      " & TimeOfDay.ToString("h:mm:ss tt"))
            ListBox1.Items.Add("      JOB.JOB" & im)
            ListBox1.Items.Add("OBS    USB   DATA   CNFG")

            Shortcutexp.RichTextBox1.Text = "الوقت والتاريخ"
        End If
        '#######################################
        If nm = 0 Then
            ListBox1.Items.Add("DATA")
            ListBox1.Items.Add("    JOB")
            ListBox1.Items.Add("    Known Data")
            ListBox1.Items.Add("    code")
            ListBox1.Items.Add("     ")
            ListBox1.Items.Add("     ")
            Shortcutexp.RichTextBox1.Text = "عرض البيانات"
        End If
        If nm = 1 Then
            ListBox1.Items.Add("JOB")
            ListBox1.Items.Add("    Job Selection")
            ListBox1.Items.Add("    Job Details")
            ListBox1.Items.Add("    Job Deletion")
            ListBox1.Items.Add("    Comms output")
            ListBox1.Items.Add("    Comms Setup")
            Shortcutexp.RichTextBox1.Text = "التعامل مع ملفات العمل"
        End If
        If nm = 2 Then
            ListBox1.Items.Add("Known Data")
            ListBox1.Items.Add("    job.JOB" & im)
            ListBox1.Items.Add("    Key in coord")
            ListBox1.Items.Add("    comms Input")
            ListBox1.Items.Add("    Deletion")
            ListBox1.Items.Add("    View                         V")
            Shortcutexp.RichTextBox1.Text = "ادخال بيانات معلومة والتعامل معها"
        End If
        If nm = 3 Then
            ListBox1.Items.Add("code")
            ListBox1.Items.Add("    key in code")
            ListBox1.Items.Add("    comms Input")
            ListBox1.Items.Add("    comms Output")
            ListBox1.Items.Add("    Deletion")
            ListBox1.Items.Add("    Code View                  V")
            Shortcutexp.RichTextBox1.Text = "تصنيف النقاط وتميزها"
        End If
        '###################'' JOB ''##########VVVVVVV###########
        If nm = 4 Then
            ListBox1.Items.Add("Job Selection")
            ListBox1.Items.Add("    JOB" & im)
            ListBox1.Items.Add("Coord search JOB")
            ListBox1.Items.Add("    JOB1")
            ListBox1.Items.Add("        ")
            ListBox1.Items.Add("List")
            Shortcutexp.RichTextBox1.Text = "اختيار ملف العمل من الاسهم او من القائمة"
        End If
        If nm = 5 Then
            ListBox1.Items.Add("Job Details")
            ListBox1.Items.Add("      JOB name           A")
            ListBox1.Items.Add("         JOB" & im)
            ListBox1.Items.Add("Scale      1.00000000")
            ListBox1.Items.Add("        ")
            ListBox1.Items.Add("                                 OK")
            Shortcutexp.RichTextBox1.Text = "تغير اسم ملف العمل او مقياس الجى بى اس"
        End If
        If nm = 6 Then
            ListBox1.Items.Add("Job Deletion")
            ListBox1.Items.Add("      JOB1            0")
            ListBox1.Items.Add("      JOB2            0")
            ListBox1.Items.Add("      JOB3            0")
            ListBox1.Items.Add("      JOB4            0")
            ListBox1.Items.Add("      JOB5            0")
            Shortcutexp.RichTextBox1.Text = "اختيار ملف العمل المراد مسح بياناته"
        End If
        If nm = 7 Then
            ListBox1.Items.Add("      JOB6            0")
            ListBox1.Items.Add("      JOB7            0")
            ListBox1.Items.Add("      JOB8            0")
            ListBox1.Items.Add("      JOB9            0")
            ListBox1.Items.Add("      JOB10           0")
            Shortcutexp.RichTextBox1.Text = "اختيار ملف العمل المراد مسح بياناته"
        End If
        If nm = 8 Then
            '>> inside Deletion
            ListBox1.Items.Add("       ")
            ListBox1.Items.Add("       ")
            ListBox1.Items.Add("      JOB1")
            ListBox1.Items.Add("         deletion")
            ListBox1.Items.Add("             confirm?")
            ListBox1.Items.Add("NO                              YES")
            Shortcutexp.RichTextBox1.Text = "مسح بيانات ملف العمل المختار"
        End If

        '###################'' JOB ''#########^^^^^^###############
        '###################''Known Data ##########################
        If nm = 9 Then
            ListBox1.Items.Add("                          rec10000")
            ListBox1.Items.Add(" N                  0.000")
            ListBox1.Items.Add(" E                  0.000")
            ListBox1.Items.Add(" Z                  0.000")
            ListBox1.Items.Add(" PT          1 ")
            ListBox1.Items.Add("                                 OK")
            Shortcutexp.RichTextBox1.Text = "ادخل نقطة معلومة فى الملف المختار"
        End If
        If nm = 10 Then
            ListBox1.Items.Add(" PT          1 ")
            ListBox1.Items.Add(" PT          2 ")
            ListBox1.Items.Add(" PT          3 ")
            ListBox1.Items.Add(" ")
            ListBox1.Items.Add(" ")
            ListBox1.Items.Add("          FIRST  LAST   SCRH")
            Shortcutexp.RichTextBox1.Text = "عرض نقاط ملف العمل"
        End If
        If nm = 11 Then
            ListBox1.Items.Add(" PT          1 ")
            ListBox1.Items.Add(" PT          2 ")
            ListBox1.Items.Add(" PT          3 ")
            ListBox1.Items.Add(" ")
            ListBox1.Items.Add(" ")
            ListBox1.Items.Add("          FIRST  LAST   SCRH")
            Shortcutexp.RichTextBox1.Text = "عرض نقاط ملف العمل"
        End If
        '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        '!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        '#################### LIST ##################################
        If nm = 12 Then
            ListBox1.Items.Add("      JOB1            0")
            ListBox1.Items.Add("      JOB2            0")
            ListBox1.Items.Add("      JOB3            0")
            ListBox1.Items.Add("      JOB4            0")
            ListBox1.Items.Add("      JOB5            0")
            ListBox1.Items.Add("      JOB6            0")
            Shortcutexp.RichTextBox1.Text = "قائمة عرض ملفات العمل"
        End If
        If nm = 13 Then
            ListBox1.Items.Add("      JOB7            0")
            ListBox1.Items.Add("      JOB8            0")
            ListBox1.Items.Add("      JOB9            0")
            ListBox1.Items.Add("      JOB10           0")
            Shortcutexp.RichTextBox1.Text = "باقي قائمة عرض ملفات العمل"
        End If
        '########################################################
        '#################CODE#####################################
        If nm = 14 Then
            ListBox1.Items.Add("")
            ListBox1.Items.Add("Code             A")
            ListBox1.Items.Add("A          ")
            Shortcutexp.RichTextBox1.Text = "تغير تصنيف الملفات"

        End If
        If nm = 15 Then
            ListBox1.Items.Add("A")
            ListBox1.Items.Add("C")
            ListBox1.Items.Add("A")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("          FIRST  LAST    DET")
            Shortcutexp.RichTextBox1.Text = "مسح تصنيف من التصنيفات"
        End If
        If nm = 16 Then
            ListBox1.Items.Add("A")
            ListBox1.Items.Add("C")
            ListBox1.Items.Add("A")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("          FIRST  LAST       ")
            Shortcutexp.RichTextBox1.Text = "عرض تصنيف الملفات"
        End If
        If nm = 17 Then
            ListBox1.Items.Add("    Clear List")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("                                    ^")
            Shortcutexp.RichTextBox1.Text = "مسح قائمة التصنيفات الملفات"
        End If


        If nm = 18 Then
            ListBox1.Items.Add("OBS")
            ListBox1.Items.Add("                    PPm        ")
            ListBox1.Items.Add("HD        0.0000 m")
            ListBox1.Items.Add("ZA        00'00'00""")
            ListBox1.Items.Add("HA-R    00'00'00""")
            ListBox1.Items.Add("MEAS  MLM   REM   0SET")
            Shortcutexp.RichTextBox1.Text = "Observation  قائمة البرامج المساحية  الرصد"
            Shortcutexp.RichTextBox1.AppendText(vbCrLf & "المسافة الافقية  HD")
            Shortcutexp.RichTextBox1.AppendText(vbCrLf & "الزاوية الرأسية  ZA")
            Shortcutexp.RichTextBox1.AppendText(vbCrLf & "الزاوية الافقية  HA-R")
            Shortcutexp.RichTextBox1.AppendText(vbCrLf & "لقياس الضغط ودرجة الحرارة  PPm")
        End If
        If nm = 19 Then

            ListBox1.Items.Add("Dist")
            ListBox1.Items.Add("Fine "" S""")
            ListBox1.Items.Add("            PPM           0")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("                              STOP")
            Shortcutexp.RichTextBox1.Text = "عملية قياس  المسافة الافقية"
            Shortcutexp.RichTextBox1.AppendText(vbCrLf & "لتشغيل ليزر التوجيه بالضغط على 0 الاسود ضغطة طويلة بجوار")

        End If
        If nm = 20 Then
            ListBox1.Items.Add("MLM")
            ListBox1.Items.Add("   Occ . Orion.")
            ListBox1.Items.Add("   MLM")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")
            Shortcutexp.RichTextBox1.Text = "عملية قياس المسافة بين نقطتين"
        End If
        If nm = 21 Then
            ListBox1.Items.Add("MLM")
            ListBox1.Items.Add("      SET  PT2     ")
            ListBox1.Items.Add("HD        0.0000 m")
            ListBox1.Items.Add("ZA        00'00'00""")
            ListBox1.Items.Add("HA-R    00'00'00""")
            ListBox1.Items.Add("MOVE  REC   MEAS    MLM")

            Shortcutexp.RichTextBox1.Text = "عملية اختيار النقطتين لقياس المسافة بينهم"
            Shortcutexp.RichTextBox1.AppendText(vbCrLf & "اولا التوجيه ثم الرصد بالضغط على MLM ")
            Shortcutexp.RichTextBox1.AppendText(vbCrLf & "ثانيا التوجيه على النقطة الثانية ثم الرصد بالضغط على MLM ")
        End If
        If nm = 22 Then
            ListBox1.Items.Add("MLM")
            ListBox1.Items.Add("SD        0.0000 m")
            ListBox1.Items.Add("HD        0.0000 m")
            ListBox1.Items.Add("VD        0.0000 m")
            ListBox1.Items.Add(" ")
            ListBox1.Items.Add("MOVE  REC   MEAS    MLM")

        End If
        If nm = 23 Then
            ListBox1.Items.Add("REM")
            ListBox1.Items.Add("   Occ . Orion.")
            ListBox1.Items.Add("   REM")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")

            Shortcutexp.RichTextBox1.Text = "عملية قياس ارتفاع نقطة دون وضع العاكس علية"

        End If

        If nm = 24 Then
            ListBox1.Items.Add("Clear")
            ListBox1.Items.Add("Comms Setup")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("                                    ^")

        End If
        If nm = 25 Then
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("Clear")
            ListBox1.Items.Add("     confirm?")
            ListBox1.Items.Add("                       NO    YES")

        End If
        If nm = 26 Then
            ListBox1.Items.Add("     Intersect")
            ListBox1.Items.Add("     Traverse")
            ListBox1.Items.Add("     Read")
            ListBox1.Items.Add("     Reaction")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")

        End If
        If nm = 27 Then
            ListBox1.Items.Add("MENU")
            ListBox1.Items.Add("    Coordinate")
            ListBox1.Items.Add("    S-O")
            ListBox1.Items.Add("    Offest")
            ListBox1.Items.Add("    Topography")
            ListBox1.Items.Add("    MLM")

        End If
        If nm = 28 Then
            ListBox1.Items.Add("    REM")
            ListBox1.Items.Add("    Area calc.")
            ListBox1.Items.Add("    S-O  Line")
            ListBox1.Items.Add("    S-o  Arc")
            ListBox1.Items.Add("    P-Project")
            ListBox1.Items.Add("    PT to Line")

        End If
        If nm = 29 Then
            ListBox1.Items.Add("REM")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("HD       0.00000 m")
            ListBox1.Items.Add("ZA       0.00000 m")
            ListBox1.Items.Add("HA-R     0.00000 m")

            ListBox1.Items.Add("            HT   REM   MEAS")

        End If
        If nm = 30 Then
            ListBox1.Items.Add("Height")
            ListBox1.Items.Add("    HI       0.000 m")
            ListBox1.Items.Add("    HR       0.000 m")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("                  OK")

            Shortcutexp.RichTextBox1.Text = "ارتفاع العاكس وارتفاع الجهاز"
        End If
        If nm = 31 Then
            ListBox1.Items.Add("USB")
            ListBox1.Items.Add("    T Type")
            ListBox1.Items.Add("    S-Type")


        End If
        If nm = 32 Then
            ListBox1.Items.Add("USB")
            ListBox1.Items.Add("  Save data")
            ListBox1.Items.Add("  Load Known PT")
            ListBox1.Items.Add("  Save Code")
            ListBox1.Items.Add("  Load Code")
            ListBox1.Items.Add("  File Status")
        End If
        If nm = 33 Then
            ListBox1.Items.Add("REM")
            ListBox1.Items.Add("Ht       0.00000 m")
            ListBox1.Items.Add("HD       0.00000 m")
            ListBox1.Items.Add("ZA       0.00000 m")
            ListBox1.Items.Add("HA-R     0.00000 m")

            ListBox1.Items.Add("     REC    HT   REM   MEAS")
            Shortcutexp.RichTextBox1.Text = "قياس ارتفاع نقطة بعد وضع ارتفاع الجهاز وارتفاع العاكس وقياس المسافة الافقية"
        End If

        If nm = 34 Then
            ListBox1.Items.Add("Crood")
            ListBox1.Items.Add("   OCC . Orin.")
            ListBox1.Items.Add("   Observtion")
            ListBox1.Items.Add("   EDM")
            ListBox1.Items.Add("")

            ListBox1.Items.Add("")
            Shortcutexp.RichTextBox1.Text = "عملية رفع الاحداثيات"
        End If
        If nm = 35 Then
            ListBox1.Items.Add("N0:         0.0000 m")
            ListBox1.Items.Add("S0:         0.0000 m")
            ListBox1.Items.Add("Z0:         0.0000 m")
            ListBox1.Items.Add("PT:          1")
            ListBox1.Items.Add("HI:         0.000 m")

            ListBox1.Items.Add("Load BS-AZ BS-NEZ RESEC")
            Shortcutexp.RichTextBox1.Text = "عملية وضع احداثيات النقطة المحتلة وارتفاع الجهاز "
            Shortcutexp.RichTextBox1.AppendText(vbCrLf & "ادخال البكسيت كزاوية او انحراف من الشمال BS-AZ")
            Shortcutexp.RichTextBox1.AppendText(vbCrLf & "ادخال البكسيت كاحداثيات BS-NTZ")
        End If
        If nm = 36 Then
            ListBox1.Items.Add("Backsight")
            ListBox1.Items.Add("Take  Bs")
            ListBox1.Items.Add("Z0:         0.0000 m")
            ListBox1.Items.Add("HA-R:         00'00'00'")
            ListBox1.Items.Add("HA-R:         00'00'00'")
            ListBox1.Items.Add("REC                     OK")
            Shortcutexp.RichTextBox1.Text = "عملية تسجيل زاوية الانحراف "

        End If
        If nm = 37 Then
            ListBox1.Items.Add("Backsight")
            ListBox1.Items.Add("NBS:         0.0000 m")
            ListBox1.Items.Add("EBS:         0.0000 m")
            ListBox1.Items.Add("ZBS:         0.0000 m")
            ListBox1.Items.Add(" ")
            ListBox1.Items.Add("Load                     OK")
            Shortcutexp.RichTextBox1.Text = "عملية تسجيل احداثيات نقطة الربط Backsight نقطة معلومة "

        End If
        If nm = 38 Then
            ListBox1.Items.Add("Backsight")
            ListBox1.Items.Add("Take  Bs")
            ListBox1.Items.Add("Z0:         0.0000 m")
            ListBox1.Items.Add("HA-R:         00'00'00'")
            ListBox1.Items.Add("Azmth:         00'00'00'")
            ListBox1.Items.Add("REC  Meas       NO     YES")
            Shortcutexp.RichTextBox1.Text = "عند الضفط على موافقة يتم الربط بين النقطتيتن لرفع اى نقطه غير معلومة "

        End If
        '############ topo menu #####################
        If nm = 39 Then
            'p1
            ListBox1.Items.Add("TOPO  JOB1")
            ListBox1.Items.Add("  Occupy")
            ListBox1.Items.Add("  BS data")
            ListBox1.Items.Add("  Angle data")
            ListBox1.Items.Add("  Dist data")
            ListBox1.Items.Add("  Coord data")
        End If
        If nm = 40 Then
            'p2
            ListBox1.Items.Add("  Dist+Coord")
            ListBox1.Items.Add("  Note")
            ListBox1.Items.Add("  View")
            ListBox1.Items.Add("  Deletion")
            ListBox1.Items.Add("")
            ListBox1.Items.Add(" ")
        End If
        '########################################


        '######## Star key mode ##################
        If nm = 41 Then
            'p1
            ListBox1.Items.Add("Entry menu")
            ListBox1.Items.Add("Tilt crn        : Yes(H,V)")
            ListBox1.Items.Add("Contrast        :10")
            ListBox1.Items.Add("Reticle lev     :3")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("  Press <Enter> Key")
        End If
        If nm = 42 Then
            'p2
            ListBox1.Items.Add("Reflector     :Prism")
            ListBox1.Items.Add("Laser Pulm    :Off")
            ListBox1.Items.Add("Laser lev.    :3")
            ListBox1.Items.Add("LLLum.hold    :Laser")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")
        End If
        If nm = 43 Then
            'p3
            ListBox1.Items.Add("L-pionter   :Off")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("    Off   on")
        End If
        '#########################################
        '############## CoFig Menu ###############
        If nm = 44 Then
            'p1
            ListBox1.Items.Add("Config")
            ListBox1.Items.Add("  Obs condition")
            ListBox1.Items.Add("  Instr.config")
            ListBox1.Items.Add("  Instr.const")
            ListBox1.Items.Add("  Comms setup")
            ListBox1.Items.Add("  Unit")
        End If
        If nm = 45 Then
            'p2
            ListBox1.Items.Add("Key function")
            ListBox1.Items.Add("Change Password")
            ListBox1.Items.Add("Date and time")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")
        End If
        '#####################################
        '################ Usb P2 ##############
        If nm = 46 Then
            ListBox1.Items.Add("Quick format")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")
        End If
        '######################################
        '################ TiLt ##############
        If nm = 47 Then
            ListBox1.Items.Add("Tilt")
            ListBox1.Items.Add("   X  -1'00"" ")
            ListBox1.Items.Add("   Y  +2'05"" ")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("OK    L-ON")
        End If
        If nm = 48 Then
            ListBox1.Items.Add("Tilt")
            ListBox1.Items.Add("   X  -1'00"" ")
            ListBox1.Items.Add("   Y  +2'05"" ")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("L-lev. >>>>")
            ListBox1.Items.Add("OK    L-ON")
        End If
        '######################################
        '################ Password ##############
        If nm = 49 Then
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("                 A")
            ListBox1.Items.Add("Password:********")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")
        End If

        '######################################
        '################ 0 SET ##############
        If nm = 50 Then
            ListBox1.Items.Add("0 Set")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("   Take F1")
            ListBox1.Items.Add("ZA     V1")
            ListBox1.Items.Add("HA-R     0'00'00"" ")
            ListBox1.Items.Add("           OK")
        End If

        '######################################

        '############# COmms Setup ###########
        If nm = 51 Then
            ListBox1.Items.Add("Wireless    :Yes")
            ListBox1.Items.Add("Bluetooth setup")
            ListBox1.Items.Add("Link device list")
            ListBox1.Items.Add("My device info")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")
        End If
        If nm = 52 Then
            ListBox1.Items.Add("Mode        :Slave")
            ListBox1.Items.Add(" ")
            ListBox1.Items.Add("Authentication   :No")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("Check Sum        :No")

        End If
        If nm = 53 Then
            ListBox1.Items.Add("Mode        :Master")
            ListBox1.Items.Add("Link   Device1")
            ListBox1.Items.Add("Authentication   :Yes")
            ListBox1.Items.Add("Passkey")
            ListBox1.Items.Add(":*******")
            ListBox1.Items.Add("Check Sum        :No")
        End If

        If nm = 54 Then
            ListBox1.Items.Add("Link device list")
            ListBox1.Items.Add("     Device1")
            ListBox1.Items.Add("     Device2")
            ListBox1.Items.Add("     Device3")
            ListBox1.Items.Add("     Device4          v")
            ListBox1.Items.Add("EDIT            DEL")
        End If
        If nm = 55 Then
            ListBox1.Items.Add("Device (Details) ")
            ListBox1.Items.Add("  Name: ")
            ListBox1.Items.Add("     Device2")
            ListBox1.Items.Add("  BD_ADDR:")
            ListBox1.Items.Add("     0123456789AB")
            ListBox1.Items.Add("PREV             NEXT")
        End If
        If nm = 56 Then
            ListBox1.Items.Add(" ")
            ListBox1.Items.Add("DEVICE 1")
            ListBox1.Items.Add("  deletion")
            ListBox1.Items.Add("    Confirm?")
            ListBox1.Items.Add("           ")
            ListBox1.Items.Add("             NO YES")
        End If
        If nm = 57 Then
            ListBox1.Items.Add("Device registration ")
            ListBox1.Items.Add("  Name:")
            ListBox1.Items.Add("    DEVICE1")
            ListBox1.Items.Add("  BD_ADDR:")
            ListBox1.Items.Add("    0123456789AB")
            ListBox1.Items.Add("SEARCH          REG")
        End If
        If nm = 58 Then
            ListBox1.Items.Add("Inquiry...")
            ListBox1.Items.Add("  0123456789AB")
            ListBox1.Items.Add("  123456789ABC")
            ListBox1.Items.Add("  23456789ABCD")
            ListBox1.Items.Add("  3456789ABCDE")
            ListBox1.Items.Add("           STOP   OK")
        End If
        '#####################################
        If nm = 59 Then
            ListBox1.Items.Add("Inquiry...")
            ListBox1.Items.Add("  0123456789AB")
            ListBox1.Items.Add("  123456789ABC")
            ListBox1.Items.Add("  23456789ABCD")
            ListBox1.Items.Add("  3456789ABCDE")
            ListBox1.Items.Add("           STOP   OK")
        End If
        If nm = 60 Then
            ListBox1.Items.Add("Bluetooth ID:")
            ListBox1.Items.Add("  XXXXXXX,XXXXXXXX")
            ListBox1.Items.Add("Firmware : X.X.X")
            ListBox1.Items.Add("   ")
            ListBox1.Items.Add("BD_ADDR:")
            ListBox1.Items.Add("    ABCDEF012345")
        End If
        If nm = 61 Then
            ListBox1.Items.Add("Set H angle")
            ListBox1.Items.Add("  Angle")
            ListBox1.Items.Add("  Coord")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")
        End If
        If nm = 62 Then
            ListBox1.Items.Add("Set H angle")
            ListBox1.Items.Add("Take BS")
            ListBox1.Items.Add("ZA     00'00'00"" ")
            ListBox1.Items.Add("HA-R   00'00'00"" ")
            ListBox1.Items.Add("HA-R   000.0000")
            ListBox1.Items.Add("REC              OK")
        End If
        If nm = 63 Then
            ListBox1.Items.Add("Set H angle/BS")
            ListBox1.Items.Add("NBS:      000.000")
            ListBox1.Items.Add("EBS:      000.000")
            ListBox1.Items.Add("ZBS:      <Null>")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("LOAD              OK")
        End If
        If nm = 64 Then
            ListBox1.Items.Add("Set H angle/BS")
            ListBox1.Items.Add("Take BS")
            ListBox1.Items.Add("ZA     00'00'00"" ")
            ListBox1.Items.Add("HA-R   00'00'00"" ")
            ListBox1.Items.Add("Azmth   00'00'00"" ")
            ListBox1.Items.Add("REC        NO  YES")
        End If
        If nmm = 65 Then
            ListBox1.Items.Add("OBS")
            ListBox1.Items.Add("                    PPm        ")
            ListBox1.Items.Add("SD    000.0000 m")
            ListBox1.Items.Add("HD    000.0000 m")
            ListBox1.Items.Add("VD    000.0000 m")
            ListBox1.Items.Add("TSEV  Tilt   SHV    EDM")
            Shortcutexp.RichTextBox1.Text = "يقوم باظهار " & vbCrLf
            Shortcutexp.RichTextBox1.AppendText("المسافة المائلة المرصودة SD" & vbCrLf)
            Shortcutexp.RichTextBox1.AppendText("المسافة الافقية المرصودة HD" & vbCrLf)
            Shortcutexp.RichTextBox1.AppendText("فرق الارتفاع المرصود VD" & vbCrLf)

        End If
        If nmm = 66 Then
            ListBox1.Items.Add("BS Hdist check")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("calc HD    000.0000 m")
            ListBox1.Items.Add("obs  HD    000.0000 m")
            ListBox1.Items.Add("dHD        000.0000 m")
            ListBox1.Items.Add("REC     HT          OK")
        End If
        If nmm = 67 Then
            ListBox1.Items.Add("Resection")
            ListBox1.Items.Add(" NEZ")
            ListBox1.Items.Add(" Elevation")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")
        End If

        If nmm = 68 Then
            ListBox1.Items.Add("Resection   1st PT")
            ListBox1.Items.Add("SD")
            ListBox1.Items.Add("ZA     000'00'00"" ")
            ListBox1.Items.Add("HA-R   000'00'00"" ")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("              ANGLE   MEAS")
        End If
        If nmm = 69 Then
            ListBox1.Items.Add("Resection   1st PT")
            ListBox1.Items.Add("SD")
            ListBox1.Items.Add("ZA     000'00'00"" ")
            ListBox1.Items.Add("HA-R   000'00'00"" ")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("                      MEAS")
        End If
        If nmm = 70 Then
            ListBox1.Items.Add("   1st PT")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("Zp:      00.000")
            ListBox1.Items.Add("HR        0.000 m")
            ListBox1.Items.Add("LOAD  REC    NEXT   CALC")
        End If
        If nmm = 71 Then
            ListBox1.Items.Add("N      000.000")
            ListBox1.Items.Add("E      000.000")
            ListBox1.Items.Add("Z      000.000")
            ListBox1.Items.Add("HR:      0.000m")
            ListBox1.Items.Add("CD")
            ListBox1.Items.Add("REC  OFFSET  AUTO  MEAS")
        End If
        If nmm = 72 Then
            ListBox1.Items.Add("S-O")
            ListBox1.Items.Add(" Occ.Orien")
            ListBox1.Items.Add(" S-O data")
            ListBox1.Items.Add(" Observation")
            ListBox1.Items.Add(" EDM")
            ListBox1.Items.Add("")
        End If
        If nmm = 73 Then
            ListBox1.Items.Add("S-O Crood")
            ListBox1.Items.Add("Np:       000.000")
            ListBox1.Items.Add("Ep:       000.000")
            ListBox1.Items.Add("Zp:        00.000")
            ListBox1.Items.Add("HR          0.000 m")
            ListBox1.Items.Add("LOAD DISP        OK")
        End If
        If nmm = 74 Then
            ListBox1.Items.Add("Resection   1st PT")
            ListBox1.Items.Add("SD")
            ListBox1.Items.Add("ZA     000'00'00"" ")
            ListBox1.Items.Add("HA-R   000'00'00"" ")
            ListBox1.Items.Add("HR         0.000 m ")
            ListBox1.Items.Add("                NO   YES")
        End If
        If nmm = 75 Then
            ListBox1.Items.Add("S-O HD")
            ListBox1.Items.Add(" ")
            ListBox1.Items.Add("Hdist :   0.000 m")
            ListBox1.Items.Add("H ang :   00.0000 ")
            ListBox1.Items.Add("                 P1")
            ListBox1.Items.Add("LOAD DISP               OK")
        End If
        If nmm = 76 Then
            ListBox1.Items.Add("S-OΔHD       0.00 m")
            ListBox1.Items.Add("dHA        0'00'00"" ")
            ListBox1.Items.Add("HD         0.000 m")
            ListBox1.Items.Add("ZA         00'00'00"" ")
            ListBox1.Items.Add("HA-R       00.0000")
            ListBox1.Items.Add("REC  DIS      <  >   MEAS")
        End If
        If nmm = 77 Then
            ListBox1.Items.Add("S-OΔHD       0.00 m")
            ListBox1.Items.Add("dHA        0'00'00"" ")
            ListBox1.Items.Add("HD         0.000 m")
            ListBox1.Items.Add("ZA         00'00'00"" ")
            ListBox1.Items.Add("HA-R       00.0000")
            ListBox1.Items.Add("                        STOP")
        End If
        If nmm = 78 Then
            ListBox1.Items.Add("S-O Ht")
            ListBox1.Items.Add(" ")
            ListBox1.Items.Add("Height :   0.000 m")
            ListBox1.Items.Add("HR         0.000 m ")
            ListBox1.Items.Add("                 P1")
            ListBox1.Items.Add("     DISP               OK")
        End If
        If nmm = 79 Then
            ListBox1.Items.Add(" v  Cutl        0.000 m")
            ListBox1.Items.Add(" ")
            ListBox1.Items.Add("SD       0.000 m")
            ListBox1.Items.Add("ZA       00'00'00"" ")
            ListBox1.Items.Add("HA-R     00'00'00"" ")
            ListBox1.Items.Add("MEAS  DISP   <  >  REM")
        End If
        If nmm = 80 Then
            ListBox1.Items.Add("Set-out line")
            ListBox1.Items.Add(" Occ.Orien ")
            ListBox1.Items.Add(" Define baseline")
            ListBox1.Items.Add(" Set-out line")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")
        End If
        If nmm = 81 Then
            ListBox1.Items.Add(" Define 1st PT")
            ListBox1.Items.Add("Np:      000.000")
            ListBox1.Items.Add("Ep:      000.000")
            ListBox1.Items.Add("Zp:      000.000")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("LOAD  REC  MEAS  OK")
        End If
        If nmm = 82 Then
            ListBox1.Items.Add(" Define 2st PT")
            ListBox1.Items.Add("Np:      000.000")
            ListBox1.Items.Add("Ep:      000.000")
            ListBox1.Items.Add("Zp:      000.000")
            ListBox1.Items.Add("                 P1")
            ListBox1.Items.Add("LOAD  REC  MEAS  OK")
        End If

        If nmm = 83 Then
            ListBox1.Items.Add(" Define 2st PT")
            ListBox1.Items.Add("Np:      000.000")
            ListBox1.Items.Add("Ep:      000.000")
            ListBox1.Items.Add("Zp:      000.000")
            ListBox1.Items.Add("                 P2")
            ListBox1.Items.Add("                       OBS")
        End If
        If nmm = 84 Then
            ListBox1.Items.Add("Measure 1st PT")
            ListBox1.Items.Add("Np:      000.000")
            ListBox1.Items.Add("Ep:      000.000")
            ListBox1.Items.Add("Zp:      000.000")
            ListBox1.Items.Add("                 P2")
            ListBox1.Items.Add("                       MEAS")
        End If
        If nmm = 85 Then
            ListBox1.Items.Add("Measure 1st PT")
            ListBox1.Items.Add("SD      000.000")
            ListBox1.Items.Add("ZA      000.000")
            ListBox1.Items.Add("HA-R      000.000")
            ListBox1.Items.Add("HR                P2")
            ListBox1.Items.Add("                  NO  YES")
        End If
        If nmm = 86 Then
            ListBox1.Items.Add("Azmth  00'00'00"" ")
            ListBox1.Items.Add("Hcalc      000.000")
            ListBox1.Items.Add("Hmeas      000.000")
            ListBox1.Items.Add("ScaleX      000.000")
            ListBox1.Items.Add("ScaleY                v")
            ListBox1.Items.Add("Sy=1   Sy=Sx           OK")
        End If
        If nmm = 87 Then
            ListBox1.Items.Add("Grade   %-2.669    ^")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("      1:      %     OK ")
        End If
        If nmm = 88 Then
            ListBox1.Items.Add("Set-out line")
            ListBox1.Items.Add("  Point")
            ListBox1.Items.Add("  Line")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")
        End If
        If nmm = 89 Then
            ListBox1.Items.Add("Np")
            ListBox1.Items.Add("Ep")
            ListBox1.Items.Add("Zp")
            ListBox1.Items.Add("ZA      000.000")
            ListBox1.Items.Add("HA-R      000.000")
            ListBox1.Items.Add("REC  HT  MEAS  OK")
        End If
        If nmm = 90 Then
            ListBox1.Items.Add("Set-out line")
            ListBox1.Items.Add("Incr        0.000m")
            ListBox1.Items.Add("Line        0.000 m")
            ListBox1.Items.Add("Offset      000.000")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("OFFSET    v    ^    OK")
        End If
        If nmm = 91 Then
            ListBox1.Items.Add("Set-out line")
            ListBox1.Items.Add("N        000.000")
            ListBox1.Items.Add("E        00.000")
            ListBox1.Items.Add("Z        000.000")
            ListBox1.Items.Add("")
            ListBox1.Items.Add("REC                S-O")
        End If

    End Sub
    Private Sub F3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F3.Click
        Bp.Play()
        rightchoice = "Data"

        If Button3.Text = "OFF" Then
            If ListBox1.Items.Item(5) = "MEAS  MLM   REM   0SET" Then
                ff(23)
            ElseIf ListBox1.Items.Item(5) = "            HT   REM   MEAS" Then
                ff(33)
            ElseIf ListBox1.Items.Item(5) = "Load BS-AZ BS-NEZ RESEC" Then
                ff(37)
            ElseIf ListBox1.Items.Item(5) = "TSEV  Tilt   SHV    EDM" Then
                ff(65)

            End If
            If nmm = 81 Or nmm = 82 Then ff(89)
            If nmm = 22 Then
                ff(19)
            End If
            If door = True Then
                Me.Text = "int = " & int & "ListBox selectedindex = " & ListBox1.SelectedIndex
                int += 1
                If int = 1 Then
                    'TextBox1.Text = "DATA"
                    'TextBox1.Text = TextBox1.Text & vbCrLf & "    JOB"
                    'TextBox1.Text = TextBox1.Text & vbCrLf & "    Known Data"
                    'TextBox1.Text = TextBox1.Text & vbCrLf & "    code"

                    ListBox1.Items.Clear()

                    ff(0)
                    rightchoice = "on"
                ElseIf int = 2 Then
                    'TextBox1.Text = "JOB"
                    'TextBox1.Text = TextBox1.Text & vbCrLf & "    Job Selection"
                    'TextBox1.Text = TextBox1.Text & vbCrLf & "    Job Details"
                    'TextBox1.Text = TextBox1.Text & vbCrLf & "    Job Deletion"
                    'TextBox1.Text = TextBox1.Text & vbCrLf & "    Comms output"
                    'TextBox1.Text = TextBox1.Text & vbCrLf & "    Comms Setup"

                    ListBox1.Items.Clear()
                    If ListBox1.SelectedIndex = 1 Then
                        ListBox1.Items.Add("JOB")
                        ListBox1.Items.Add("    Job Selection")
                        ListBox1.Items.Add("    Job Details")
                        ListBox1.Items.Add("    Job Deletion")
                        ListBox1.Items.Add("    Comms output")
                        ListBox1.Items.Add("    Comms Setup")
                    End If
                ElseIf int = 3 Then
                    'TextBox1.Text = "Known Data"
                    'TextBox1.Text = TextBox1.Text & vbCrLf & "    job.JOB1"
                    'TextBox1.Text = TextBox1.Text & vbCrLf & "    Key in coord"
                    'TextBox1.Text = TextBox1.Text & vbCrLf & "    comms Input"
                    'TextBox1.Text = TextBox1.Text & vbCrLf & "    Deletion"
                    'TextBox1.Text = TextBox1.Text & vbCrLf & "    View"


                    If pin = "k" Then
                        ListBox1.Items.Clear()
                        ListBox1.Items.Add("Known Data")
                        ListBox1.Items.Add("    job.JOB" & im)
                        ListBox1.Items.Add("    Key in coord")
                        ListBox1.Items.Add("    comms Input")
                        ListBox1.Items.Add("    Deletion")
                        ListBox1.Items.Add("    View")
                    End If
                ElseIf int = 4 Then
                    'TextBox1.Text = "code"
                    'TextBox1.Text = TextBox1.Text & vbCrLf & "    key in code"
                    'TextBox1.Text = TextBox1.Text & vbCrLf & "    comms Input"
                    'TextBox1.Text = TextBox1.Text & vbCrLf & "    comms Output"
                    'TextBox1.Text = TextBox1.Text & vbCrLf & "    Deletion"
                    'TextBox1.Text = TextBox1.Text & vbCrLf & "    Code View"
                    'TextBox1.Text = TextBox1.Text & vbCrLf & "    Clear List"

                    ListBox1.Items.Clear()
                    If pin = "c" Then
                        ListBox1.Items.Add("code")
                        ListBox1.Items.Add("    key in code")
                        ListBox1.Items.Add("    comms Input")
                        ListBox1.Items.Add("    comms Output")
                        ListBox1.Items.Add("    Deletion")
                        ListBox1.Items.Add("    Code View")
                        ListBox1.Items.Add("    Clear List")
                    End If
                    int = 0

                End If
            End If
        Else
        End If
    End Sub
    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Esc.Click

        If Button3.Text = "OFF" Then
            ListBox1.Items.Clear()
            nmm = 100
            Bp.Play()
            'TextBox1.Text = "CX - 101        rec10000"
            'TextBox1.Text = TextBox1.Text & vbCrLf & "S/N  000000"
            'TextBox1.Text = TextBox1.Text & vbCrLf & "Ver . 103N"
            'TextBox1.Text = TextBox1.Text & vbCrLf & "           1.0"
            'TextBox1.Text = TextBox1.Text & vbCrLf & "           "
            'TextBox1.Text = TextBox1.Text & vbCrLf & "OBS    USB   DATA   CNFG"

            ListBox1.Items.Add("CX - 101        rec10000")
            ListBox1.Items.Add(" S/N  000000")
            ListBox1.Items.Add("  Ver . 103N")
            ListBox1.Items.Add("           1.0")
            ListBox1.Items.Add("      JOB.JOB" & im)
            ListBox1.Items.Add("OBS    USB   DATA   CNFG")
            door = True
            rightchoice = "off"
            n = ""
            int = 0
        Else
        End If
    End Sub
    Private Sub F1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F1.Click
        Bp.Play()
        If nmm = 54 Then
            ff(57)
        ElseIf nmm = 57 Then
            ff(58)

        End If
        If ListBox1.Items.Item(5) = "OBS    USB   DATA   CNFG" Then
            ff(18)
        End If
        If ListBox1.Items.Item(5) = "MEAS  MLM   REM   0SET" Then
            ff(19)

        ElseIf ListBox1.Items.Item(5) = "MEAS  MLM   SHV    EDM" Then

        ElseIf ListBox1.Items.Item(5) = "MENU  TOPO    HT   H SET" Then
            ff(26)
        ElseIf ListBox1.Items.Item(5) = "Load BS-AZ BS-NEZ RESEC" Then
            ff(11)
        ElseIf ListBox1.Items.Item(5) = "Load BS-AZ BS-NEZ RESEC" Then
            ff(11)


        End If
        If Button3.Text = "OFF" Then
            If rightchoice = "off" Then
                ListBox1.Items.Clear()
                door = False
                'TextBox1.Text = "OBS"
                'TextBox1.Text = TextBox1.Text & vbCrLf & "           "
                'TextBox1.Text = TextBox1.Text & vbCrLf & "HD        0.0000 m"
                'TextBox1.Text = TextBox1.Text & vbCrLf & "ZA        00'00'00"""
                'TextBox1.Text = TextBox1.Text & vbCrLf & "HA-R    00'00'00"""
                'TextBox1.Text = TextBox1.Text & vbCrLf & "MEAS  MLM   REM   0SET"

                ff(18)


                rightchoice = "on"
            End If








            If nmm = 4 Then ff(12)

        Else
        End If

        '  If nmm = 19 Then audio.Play()



    End Sub
    Private Sub Down_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Down.Click
        If Button3.Text = "OFF" Then
            Bp.Play()
            m += 1
            If m = ListBox1.Items.Count Or m = 5 Then
                m = 1
            End If
            ListBox1.SelectedIndex = m
            If nmm = 26 Then
                ff(27)
            ElseIf nmm = 27 Then
                ff(28)
            ElseIf nmm = 28 Then
                ff(26)
            End If


            If nmm = 87 Then
                ff(86)
            ElseIf nmm = 86 Then
                ff(87)
            End If
        Else
        End If
    End Sub
    Private Sub Up_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Up.Click
        If Button3.Text = "OFF" Then
            Bp.Play()
            If m = ListBox1.Items.Count Or m = 1 Then
                m = 5
            End If
            m -= 1
            ListBox1.SelectedIndex = m

            If nmm = 28 Then
                ff(27)
            ElseIf nmm = 27 Then
                ff(26)
            ElseIf nmm = 26 Then
                ff(28)
            End If


            If nmm = 87 Then
                ff(86)
            ElseIf nmm = 86 Then
                ff(87)
            End If
        Else
        End If
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

        int = ListBox1.SelectedIndex
        Me.Text = "int = " & int & "**ListBox selectedindex = " & ListBox1.SelectedIndex & "** Value = " & ListBox1.SelectedItem & "** ID = " & nmm
        If ListBox1.SelectedIndex = 1 Then pin = "j"
        If ListBox1.SelectedIndex = 2 Then pin = "k"
        If ListBox1.SelectedIndex = 3 Then pin = "c"



        If ListBox1.SelectedItem = "DATA" Then Shortcutexp.RichTextBox1.Text = " التعامل مع البيانات"
        If ListBox1.SelectedItem = "    JOB" Then Shortcutexp.RichTextBox1.Text = "ملفات العمل"
        If ListBox1.SelectedItem = "    Known Data" Then Shortcutexp.RichTextBox1.Text = " التعامل مع بيانات معروفة"
        If ListBox1.SelectedItem = "    code" Then Shortcutexp.RichTextBox1.Text = "تصنيف البيانات"

        If ListBox1.SelectedItem = "JOB" Then Shortcutexp.RichTextBox1.Text = " ملفات العمل"
        If ListBox1.SelectedItem = "    Job Selection" Then Shortcutexp.RichTextBox1.Text = " تحديد ملف العمل او ذاكرة العمل"
        If ListBox1.SelectedItem = "    Job Details" Then Shortcutexp.RichTextBox1.Text = " تفاصيل ملف العمل"
        If ListBox1.SelectedItem = "    Job Deletion" Then Shortcutexp.RichTextBox1.Text = " مسح نقاط من ملف العمل من ذاكرة العمل"








        If ListBox1.SelectedItem = "    Known Data" Then Shortcutexp.RichTextBox1.Text = "بيانات معلومة "
        If ListBox1.SelectedItem = "    code" Then Shortcutexp.RichTextBox1.Text = "تصنيفات "
        If ListBox1.SelectedItem = "    Job Selection" Then Shortcutexp.RichTextBox1.Text = "اختيار ملف العمل "
        If ListBox1.SelectedItem = "    Job Details" Then Shortcutexp.RichTextBox1.Text = "تفاصيل ملف العمل "
        If ListBox1.SelectedItem = "    Job Deletion" Then Shortcutexp.RichTextBox1.Text = "حذف ملف العمل "
        If ListBox1.SelectedItem = "    Comms output" Then Shortcutexp.RichTextBox1.Text = "Communication out	  اخراج البيانات للكمبيوتر المستضيف"
        If ListBox1.SelectedItem = "    Comms Setup" Then Shortcutexp.RichTextBox1.Text = " Communication setup	  تعريف الجهاز المستضيف"
        If ListBox1.SelectedItem = "    Key in coord" Then Shortcutexp.RichTextBox1.Text = "إدخال المفتاح اسم واحدثيات لتسجيل بيانات إحداثيات نقطة معروفة "
        If ListBox1.SelectedItem = "    comms Input" And nmm = 2 Then Shortcutexp.RichTextBox1.Text = " Communication Input	   ادخال بيانات احداثيات معروفة عن طريق الجهاز"
        If ListBox1.SelectedItem = "    Deletion" Then Shortcutexp.RichTextBox1.Text = " حذف نقاط من ملف العمل"
        If ListBox1.SelectedItem = "    View                         V" Then Shortcutexp.RichTextBox1.Text = " عرض نقاط ملف العمل"
        If ListBox1.SelectedItem = "    key in code" Then Shortcutexp.RichTextBox1.Text = "عملية ادخال تصنيفات للاحداثيات  "
        If ListBox1.SelectedItem = "    comms Input" And nmm = 3 Then Shortcutexp.RichTextBox1.Text = "Communication input	  ادخال البيانات الاكوا والتصنيفات للكمبيوتر المستضيف "
        If ListBox1.SelectedItem = "    comms Output" And nmm = 3 Then Shortcutexp.RichTextBox1.Text = "Communication out	  اخراج البيانات للكمبيوتر المستضيف "
        If ListBox1.SelectedItem = "    Deletion" Then Shortcutexp.RichTextBox1.Text = "حذف الاكواد والتصنيفات "
        If ListBox1.SelectedItem = "    Code View                  V" Then Shortcutexp.RichTextBox1.Text = "عرض التصنيفات والاكواد "
        If ListBox1.SelectedItem = "   Occ . Orion." Then Shortcutexp.RichTextBox1.Text = "occupation orientation اتجاة النقطة المحتلة "
        If ListBox1.SelectedItem = "   MLM" Then Shortcutexp.RichTextBox1.Text = "Missing line measurement قياس خط غير معلوم "
        If ListBox1.SelectedItem = "   Occ . Orion." Then Shortcutexp.RichTextBox1.Text = "occupation orientation اتجاة النقطة المحتلة "
        If ListBox1.SelectedItem = "   REM" Then Shortcutexp.RichTextBox1.Text = "Remote elevation measurement قياس الارتفاع عن بعد "
        If ListBox1.SelectedItem = "Comms Setup" Then Shortcutexp.RichTextBox1.Text = " تعريف جهاز المتصل سلكي-للاسلكي"
        If ListBox1.SelectedItem = "     Intersect" Then Shortcutexp.RichTextBox1.Text = " تقاطع نقطتين او اكثر " 'page nummber =140
        If ListBox1.SelectedItem = "     Traverse" Then Shortcutexp.RichTextBox1.Text = "  امتدادات او قطاع والهدف عرض دقة الجهاز" 'page nmmuber=144
        If ListBox1.SelectedItem = "     Read" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "     Reaction" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "    Coordinate" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "    S-O" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "    Offest" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "    Topography" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "    MLM" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "    REM" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "    Area calc." Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "    S-O  Line" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "    S-o  Arc" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "    P-Project" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "    PT to Line" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "    T Type" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "    S-Type" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "  Save data" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "  Load Known PT" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "  Save Code" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "  Load Code" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "  File Status" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "   OCC . Orin." Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "   Observtion" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "   EDM" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "  Occupy" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "  BS data" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "  Angle data" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "  Dist data" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "  Coord data" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "  Dist+Coord" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "  Note" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "  View" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "  Deletion" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "Tilt crn        : Yes(H,V)" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "Contrast        :10" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "Reticle lev     :3" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "Reflector     :Prism" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "Laser Pulm    :Off" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "Laser lev.    :3" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "LLLum.hold    :Laser" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "L-pionter   :Off" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "  Obs condition" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "  Instr.config" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "  Instr.const" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "  Comms setup" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "  Unit" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "Key function" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "Change Password" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "Date and time" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "Quick format" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "Tilt" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "Wireless    :Yes" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "Bluetooth setup" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "Link device list" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "My device info" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "Mode        :Slave" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "Authentication   :No" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "Check Sum        :No" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "Mode        :Master" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "Link   Device1" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "Authentication   :Yes" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "Passkey" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "Link device list" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "Device (Details) " Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "Device registration " Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "Set H angle" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "  Angle" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "  Coord" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "Take BS" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = " NEZ" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = " Elevation" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = " Occ.Orien" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = " S-O data" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = " Observation" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = " EDM" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = " Occ.Orien " Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = " Define baseline" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = " Set-out line" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "  Point" Then Shortcutexp.RichTextBox1.Text = " "
        If ListBox1.SelectedItem = "  Line" Then Shortcutexp.RichTextBox1.Text = " "

        ' Me.ListBox1.Invalidate()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ListBox1.DrawMode = DrawMode.OwnerDrawFixed
        ' Form3.Show()
        Explain.Location = New Point(Me.Location.X + Me.Width, Me.Location.Y)
        'Form2.Show()
        Shortcutexp.Location = New Point(Me.Location.X, Me.Height + Me.Location.Y)
        ' sapi.speak("created b Ehab magdy")
    End Sub
    Private Sub ListBox1_DrawItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles ListBox1.DrawItem
        e.DrawBackground()
        Dim isItemSelected As Boolean = ((e.State And DrawItemState.Selected) = DrawItemState.Selected)
        Dim itemIndex As Integer = e.Index
        If itemIndex >= 0 AndAlso itemIndex < ListBox1.Items.Count Then
            Dim g As Graphics = e.Graphics
            Dim backgroundColorBrush As SolidBrush = New SolidBrush(If((isItemSelected), Color.Black, Color.Olive))
            g.FillRectangle(backgroundColorBrush, e.Bounds)
            Dim itemText As String = ListBox1.Items(itemIndex).ToString()
            Dim itemTextColorBrush As SolidBrush = If((isItemSelected), New SolidBrush(Color.White), New SolidBrush(Color.Black))
            g.DrawString(itemText, e.Font, itemTextColorBrush, ListBox1.GetItemRectangle(itemIndex).Location)
            backgroundColorBrush.Dispose()
            itemTextColorBrush.Dispose()
        End If

        e.DrawFocusRectangle()

    End Sub
    Private Sub bgwWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwWorker.DoWork
        ' Do your things   
        Thread.Sleep(3000)
    End Sub
    Private Sub bgwWorker_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwWorker.RunWorkerCompleted
        ' Called when the BackgroundWorker is completed.
        ListBox1.Visible = True
        TextBox1.Visible = False
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Shortcutexp.RichTextBox1.Text = " موديل الجهاز"
        Shortcutexp.RichTextBox1.AppendText("         عدد النقاط غير مسجلة")
        Shortcutexp.RichTextBox1.AppendText(vbCrLf & "رقم الجهاز السيريل نمبر")

        Bp.Play()

        If Button3.Text = "On" Then
            ListBox1.Items.Clear()
            Button3.Text = "OFF"
            ' ListBox1.Items.Add(" SOKKIA")
            'ListBox1.Font = New Drawing.Font("Tahoma",70,FontStyle.Regular Or FontStyle.Regular)
            TextBox1.Text = "SOKKIA" & vbCrLf & "Ehab"
            TextBox1.Font = New Drawing.Font("Tahoma", 75, FontStyle.Regular Or FontStyle.Regular)

            ' ListBox1.Size = New Drawing.Size(403, 240)

            If Not bgwWorker.IsBusy Then
                ListBox1.Visible = False
                TextBox1.Visible = True
                bgwWorker.RunWorkerAsync()
            End If

            ListBox1.Items.Add("CX - 101        rec10000")
            ListBox1.Items.Add(" S/N  000000")
            ListBox1.Items.Add("  Ver . 103N")
            ListBox1.Items.Add("           1.0")
            ListBox1.Items.Add("           ")
            ListBox1.Items.Add("OBS    USB   DATA   CNFG")
        Else
            Button3.Text = "On"
            ListBox1.Items.Clear()

        End If



    End Sub
    Private Sub Entr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Entr.Click
        'On Error Resume Next
        Bp.Play()
        If nmm = 86 And ListBox1.Items.Item(5) = "Sy=1   Sy=Sx           OK" Then ff(88) 'in F4 pressing


        If nmm = 87 And ListBox1.Items.Item(5) = "      1:      %     OK " Then ff(88) 'in F4 pressing



        If nmm = 88 And ListBox1.SelectedItem = "  Point" Then ff(90)

        If ListBox1.SelectedItem = "  Angle" Then ff(62)
        If ListBox1.SelectedItem = " NEZ" Then ff(68)
        If ListBox1.SelectedItem = " Elevation" Then ff(69)
        If ListBox1.SelectedItem = "   Observtion" Then ff(71)

        If ListBox1.SelectedItem = "    S-O  Line" Then ff(80)

        If ListBox1.SelectedItem = " Define baseline" Then ff(81)

        If ListBox1.SelectedItem = "    S-O" Then ff(72)
        If ListBox1.SelectedItem = " S-O data" Then ff(73)

        If ListBox1.SelectedItem = "  Coord" Then ff(63)

        If nmm = 23 Then
            If ListBox1.SelectedItem = "   REM" Then ff(29)
        End If

        If nmm = 34 And ListBox1.SelectedItem = "   OCC . Orin." Then
            ff(35)
        End If
        If nmm = 27 And ListBox1.SelectedItem = "    Coordinate" Then
            ff(34)
        End If
        If ListBox1.SelectedItem = "Change Password" Then ff(49)
        If ListBox1.SelectedItem = "My device info" Then ff(60)
        If ListBox1.SelectedItem = "    JOB" Then ff(1)
        If ListBox1.SelectedItem = "    Known Data" Then ff(2)
        If ListBox1.SelectedItem = "    code" Then ff(3)
        If ListBox1.SelectedItem = "Bluetooth setup" Then ff(52)
        If ListBox1.SelectedItem = "    Job Selection" Then ff(4)
        If ListBox1.SelectedItem = "    Job Details" Then ff(5)
        If ListBox1.SelectedItem = "    Job Deletion" Then ff(6)

        If ListBox1.SelectedItem = "    Key in coord" Then ff(9)
        If ListBox1.Items.Item(0) = "Known Data" And ListBox1.SelectedItem = "    Deletion" Then ff(10)
        If ListBox1.SelectedItem = "    View                         V" Then ff(11)
        If nmm = 44 And ListBox1.SelectedItem = "  Comms setup" Then ff(51)

        If ListBox1.SelectedItem = "Link device list" Then ff(54)

        If ListBox1.SelectedItems.Contains("     Device" & ListBox1.SelectedIndex) Then ff(55)



        If ListBox1.SelectedItem = "    JOB" & im Then
            ListBox1.Items.Clear()



            ListBox1.Items.Add("CX - 101        rec10000")
            ListBox1.Items.Add(" S/N  000000")
            ListBox1.Items.Add("  Ver . 103N")
            ListBox1.Items.Add("           1.0")
            ListBox1.Items.Add("      JOB.JOB" & im)
            ListBox1.Items.Add("OBS    USB   DATA   CNFG")
            door = True
            rightchoice = "off"
            int = 0
        End If
        If ListBox1.SelectedItem = "    S-Type" Then ff(32)

        If ListBox1.SelectedItem = "    key in code" Then ff(14)
        If ListBox1.Items.Item(0) = "code" And ListBox1.SelectedItem = "    Deletion" Then ff(15)
        If ListBox1.SelectedItem = "    Code View" Then ff(16)

        If ListBox1.SelectedItem = "   MLM" Then ff(21)

        If ListBox1.SelectedItem = "Clear" And ListBox1.Items.Item(0) = "Clear" Then ff(25)
        If ListBox1.Items.Item(0) = "Job Deletion" And ListBox1.SelectedItem = "      JOB" & im & "            0" Then ff(8)
    End Sub
    Private Sub Bs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bs.Click
        Bp.Play()
        If ListBox1.Items.Item(0) = "DATA" Then ff(100)

        If ListBox1.Items.Item(0) = "JOB" Then ff(0)
        If ListBox1.Items.Item(0) = "Known Data" Then ff(0)
        If ListBox1.Items.Item(0) = "code" Then ff(0)

        If ListBox1.Items.Item(0) = "Job Selection" Then ff(1)
        If ListBox1.Items.Item(0) = "Job Details" Then ff(1)
        If ListBox1.Items.Item(0) = "Job Deletion" Then ff(1)

        If nmm = 9 Then ff(2)
        If nmm = 10 Then ff(2)
        If nmm = 11 Then ff(2)
        If nmm = 6 Then ff(1)
        If nmm = 7 Then ff(1)
        If nmm = 12 Then ff(4)
        If nmm = 13 Then ff(4)
        If nmm = 14 Then ff(3)
        If nmm = 15 Then ff(3)
        If nmm = 16 Then ff(3)
        If nmm = 17 Then ff(3)
        If nmm = 19 Then ff(18)
        If nmm = 20 Then ff(18)
        If nmm = 23 Then ff(18)
    End Sub
    Private Sub Right_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Right.Click
        Bp.Play()
        im += 1
        If ListBox1.Items.Item(0) = "Mode        :Slave" Then
            ff(53)
        ElseIf ListBox1.Items.Item(0) = "Mode        :Master" Then
            ff(52)
        End If

        If ListBox1.Items.Item(0) = "Job Details" Then
            If im > 10 Then im = 1

            ListBox1.Items.Item(2) = "         JOB" & im
        End If
        If ListBox1.Items.Item(0) = "Job Selection" Then
            If im > 10 Then im = 1
            ListBox1.Items.Item(1) = "    JOB" & im
        End If
    End Sub
    Private Sub Left_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Left.Click
        Bp.Play()
        im -= 1
        If ListBox1.Items.Item(0) = "Mode        :Slave" Then
            ff(53)
        ElseIf ListBox1.Items.Item(0) = "Mode        :Master" Then
            ff(52)
        End If
        If ListBox1.Items.Item(0) = "Job Details" Then
            If im < 1 Then im = 10
            ListBox1.Items.Item(2) = "         JOB" & im
        End If
        If ListBox1.Items.Item(0) = "Job Selection" Then
            If im < 1 Then im = 10
            ListBox1.Items.Item(1) = "    JOB" & im
        End If
    End Sub
    Private Sub Shift_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Shift.Click
        Bp.Play()
        If change = False Then
            change = True
        Else
            change = False
        End If
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Bp.Play()
        If change = True Then
            ' ListBox1.Items.Item(3) = "A"
            If swth1 = 1 Then
                ListBox1.Items.Item(0) = "A" : swth1 = 0 : swth2 = 1 : swth3 = 0
            ElseIf swth2 = 1 Then
                ListBox1.Items.Item(0) = "B" : swth1 = 0 : swth2 = 0 : swth3 = 1
            ElseIf swth3 = 1 Then
                ListBox1.Items.Item(0) = "C" : swth1 = 1 : swth2 = 0 : swth3 = 0
            End If
        End If
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Bp.Play()
        If change = True Then
            ' ListBox1.Items.Item(3) = "A"
            If swth1 = 1 Then
                ListBox1.Items.Item(0) = "D" : swth1 = 0 : swth2 = 1 : swth3 = 0
            ElseIf swth2 = 1 Then
                ListBox1.Items.Item(0) = "E" : swth1 = 0 : swth2 = 0 : swth3 = 1
            ElseIf swth3 = 1 Then
                ListBox1.Items.Item(0) = "F" : swth1 = 1 : swth2 = 0 : swth3 = 0
            End If
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Bp.Play()
        If change = True Then
            ' ListBox1.Items.Item(3) = "A"
            If swth1 = 1 Then
                ListBox1.Items.Item(0) = "G" : swth1 = 0 : swth2 = 1 : swth3 = 0
            ElseIf swth2 = 1 Then
                ListBox1.Items.Item(0) = "H" : swth1 = 0 : swth2 = 0 : swth3 = 1
            ElseIf swth3 = 1 Then
                ListBox1.Items.Item(0) = "I" : swth1 = 1 : swth2 = 0 : swth3 = 0
            End If
        End If
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Bp.Play()
        If change = True Then
            ' ListBox1.Items.Item(3) = "A"
            If swth1 = 1 Then
                ListBox1.Items.Item(0) = "J" : swth1 = 0 : swth2 = 1 : swth3 = 0
            ElseIf swth2 = 1 Then
                ListBox1.Items.Item(0) = "K" : swth1 = 0 : swth2 = 0 : swth3 = 1
            ElseIf swth3 = 1 Then
                ListBox1.Items.Item(0) = "L" : swth1 = 1 : swth2 = 0 : swth3 = 0
            End If
        End If
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Bp.Play()
        If change = True Then
            ' ListBox1.Items.Item(3) = "A"
            If swth1 = 1 Then
                ListBox1.Items.Item(0) = "M" : swth1 = 0 : swth2 = 1 : swth3 = 0
            ElseIf swth2 = 1 Then
                ListBox1.Items.Item(0) = "N" : swth1 = 0 : swth2 = 0 : swth3 = 1
            ElseIf swth3 = 1 Then
                ListBox1.Items.Item(0) = "O" : swth1 = 1 : swth2 = 0 : swth3 = 0
            End If
        End If
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Bp.Play()
        If change = True Then
            ' ListBox1.Items.Item(3) = "A"
            If swth1 = 1 Then
                ListBox1.Items.Item(0) = "P" : swth1 = 0 : swth2 = 1 : swth3 = 0
            ElseIf swth2 = 1 Then
                ListBox1.Items.Item(0) = "Q" : swth1 = 0 : swth2 = 0 : swth3 = 1
            ElseIf swth3 = 1 Then
                ListBox1.Items.Item(0) = "R" : swth1 = 1 : swth2 = 0 : swth3 = 0
            End If
        End If
    End Sub
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Bp.Play()
        If change = True Then
            ' ListBox1.Items.Item(3) = "A"
            If swth1 = 1 Then
                ListBox1.Items.Item(0) = "S" : swth1 = 0 : swth2 = 1 : swth3 = 0
            ElseIf swth2 = 1 Then
                ListBox1.Items.Item(0) = "T" : swth1 = 0 : swth2 = 0 : swth3 = 1
            ElseIf swth3 = 1 Then
                ListBox1.Items.Item(0) = "U" : swth1 = 1 : swth2 = 0 : swth3 = 0
            End If
        End If
    End Sub
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Bp.Play()
        If change = True Then
            ' ListBox1.Items.Item(3) = "A"
            If swth1 = 1 Then
                ListBox1.Items.Item(0) = "V" : swth1 = 0 : swth2 = 1 : swth3 = 0
            ElseIf swth2 = 1 Then
                ListBox1.Items.Item(0) = "W" : swth1 = 0 : swth2 = 0 : swth3 = 1
            ElseIf swth3 = 1 Then
                ListBox1.Items.Item(0) = "X" : swth1 = 1 : swth2 = 0 : swth3 = 0
            End If
        End If
    End Sub
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Bp.Play()
        If change = True Then
            ' ListBox1.Items.Item(3) = "A"
            If swth1 = 1 Then
                ListBox1.Items.Item(0) = "Y" : swth1 = 0 : swth2 = 1 : swth3 = 0
            ElseIf swth2 = 1 Then
                ListBox1.Items.Item(0) = "Z" : swth1 = 0 : swth2 = 0 : swth3 = 1
            End If
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        swth1 = 1
        swth2 = 0
        swth3 = 0
    End Sub
    Private Sub Func_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Func.Click

        On Error Resume Next
        Bp.Play()
        If nmm = 47 Then
            ff(48)
        ElseIf nmm = 48 Then
            ff(47)
        End If
        If nmm = 44 Then
            ff(45)
        ElseIf nmm = 45 Then
            ff(44)
        End If

        If nmm = 40 Then
            ff(39)
        ElseIf nmm = 39 Then
            ff(40)
        End If

        If nmm = 100 Then
            ff(101)
        ElseIf nmm = 101 Then
            ff(100)
        End If


        If nmm = 6 Then
            ff(7)
        ElseIf nmm = 7 Then
            ff(6)
        End If

        If nmm = 2 Then
            ff(24)
        ElseIf nmm = 24 Then
            ff(2)
        End If

        If nmm = 12 Then
            ff(13)
        ElseIf nmm = 13 Then
            ff(12)
        End If
        If nmm = 3 Then
            ff(17)
        End If

        If ListBox1.Items.Item(5) = "MEAS  MLM   REM   0SET" Then
            ListBox1.Items.Item(5) = "TSEV  Tilt   SHV    EDM"
        ElseIf ListBox1.Items.Item(5) = "TSEV  Tilt   SHV    EDM" Then
            ListBox1.Items.Item(5) = "MENU  TOPO    HT   H SET"
        ElseIf ListBox1.Items.Item(5) = "MENU  TOPO    HT   H SET" Then
            ListBox1.Items.Item(5) = "MEAS  MLM   REM   0SET"
        End If

        If ListBox1.Items.Item(0) = " Define 2st PT" And ListBox1.Items.Item(5) = "LOAD  REC  MEAS  OK" Then
            ff(83)
        End If
    End Sub
    Private Sub F2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F2.Click
        On Error Resume Next
        Bp.Play()


        If ListBox1.Items.Item(0) = "S-O Ht" Then
            ff(73)
        ElseIf ListBox1.Items.Item(0) = "S-O Crood" Then
            ff(75)
        ElseIf ListBox1.Items.Item(0) = "S-O HD" Then
            ff(78)
        End If


        If ListBox1.Items.Item(5) = "TSEV  Tilt   SHV    EDM" Then
            ff(47)
        End If
        If ListBox1.Items.Item(5) = "REC  Meas       NO     YES" Then
            ff(66)
        End If

        If ListBox1.Items.Item(5) = "MEAS  MLM   REM   0SET" Then
            ff(20)
        ElseIf ListBox1.Items.Item(5) = "MEAS  MLM   SHV    EDM" Then




        ElseIf ListBox1.Items.Item(5) = "MENU  TOPO    HT   H SET" Then
            ff(39)
        ElseIf ListBox1.Items.Item(5) = "OBS    USB   DATA   CNFG" Then
            ff(31)
        ElseIf ListBox1.Items.Item(5) = "            HT   REM   MEAS" Then
            ff(30)
        ElseIf ListBox1.Items.Item(5) = "Load BS-AZ BS-NEZ RESEC" Then
            ff(36)
        End If

    End Sub
    Private Sub F4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F4.Click
        Bp.Play()
        If ListBox1.Items.Item(5) = "OBS    USB   DATA   CNFG" Then ff(44)
        If ListBox1.Items.Item(5) = "MENU  TOPO    HT   H SET" Then ff(61)
        If ListBox1.Items.Item(5) = "Load BS-AZ BS-NEZ RESEC" Then ff(67)
        If ListBox1.Items.Item(5) = "              ANGLE   MEAS" Then ff(74)

        If ListBox1.Items.Item(0) = " Define 1st PT" Then ff(82)

        If ListBox1.Items.Item(0) = "S-O Ht" Then ff(79)


        If ListBox1.Items.Item(5) = "REC  DIS      <  >   MEAS" Then ff(77)

        If ListBox1.Items.Item(5) = "LOAD DISP               OK" Then ff(76)

        If nmm = 69 Then ff(70)

        If nmm = 85 Then ff(86)


        If nmm = 84 Then ff(85)
        If nmm = 83 Then ff(84)



        If ListBox1.Items.Item(5) = "EDIT            DEL" Then ff(56)


        If ListBox1.Items.Item(5) = "MOVE  REC   MEAS    MLM" Then
            ff(22)
            Shortcutexp.RichTextBox1.Text = "المسافة المائلة"
            Shortcutexp.RichTextBox1.AppendText(vbCrLf & "المسافة الافقية")
            Shortcutexp.RichTextBox1.AppendText(vbCrLf & "فرق الارتفاع ")
        ElseIf ListBox1.Items.Item(5) = "            HT   REM   MEAS" Then
            ff(19)
        ElseIf ListBox1.Items.Item(5) = "MEAS  MLM   REM   0SET" Then
            ff(50)
            Shortcutexp.RichTextBox1.Text = "عملية تصفير الزاوية الافقية"

        ElseIf ListBox1.Items.Item(5) = "Load                     OK" Then

            ff(38)
        ElseIf ListBox1.Items.Item(5) = "REC  Meas       NO     YES" Then

            ff(34)
        ElseIf ListBox1.Items.Item(5) = "REC                     OK" Then
            ff(34)

        End If
        If ListBox1.Items.Item(5) = "                              STOP" Then ff(18) : audio.Stop()
    End Sub
    Private Sub Form1_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LocationChanged
        Shortcutexp.Location = New Point(Me.Location.X, +Me.Height + Me.Location.Y + 10)
        Explain.Location = New Point(Me.Location.X + Me.Width + 10, Me.Location.Y)
    End Sub
    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Bp.Play()
    End Sub
    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Bp.Play()
    End Sub
    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Bp.Play()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Bp.Play()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Bp.Play()
    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Bp.Play()
        If gh = 0 Then
            Shortcutexp.Show()
            Explain.Show()
            gh = 1
        Else
            Explain.Hide()
            Shortcutexp.Hide()
            gh = 0
        End If
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Explain.RichTextBox1.RightToLeft = Windows.Forms.RightToLeft.No
        Explain.RichTextBox1.Text = "[MEAS]	: Distance measurement" & vbCrLf
        Explain.RichTextBox1.AppendText("[SHV]	: Switch between angle display and distance display" & vbCrLf)
        Explain.RichTextBox1.AppendText("[0SET]	: Set horizontal angle to 0 " & vbCrLf)
        Explain.RichTextBox1.AppendText("[COORD]	: Coordinates measurement [REP]	: Repetition measurement" & vbCrLf)
        Explain.RichTextBox1.AppendText("[MLM]	: Missing line measurement" & vbCrLf)
        Explain.RichTextBox1.AppendText("[S-O]	: Setting-out measurement" & vbCrLf)
        Explain.RichTextBox1.AppendText("[OFFSET]: Offset(measurement)" & vbCrLf)
        Explain.RichTextBox1.AppendText("[TOPO]	: To TOPO menu" & vbCrLf)
        Explain.RichTextBox1.AppendText("[EDM]:  Setting(EDM)" & vbCrLf)
        Explain.RichTextBox1.AppendText("[H-SET]	: Set required horizontal angle" & vbCrLf)
        Explain.RichTextBox1.AppendText("[TILT]	: Display tilt angle" & vbCrLf)
        Explain.RichTextBox1.AppendText("[MENU]	: To Menu mode (Coordinates measurement, setting-out measurement, offset measurement, repetition measurement, missing line measurement, REM measurement, resection" & _
        "measurement, surface area measurement, set-out line, set-out arc, point projection, intersections, traverse)" & vbCrLf)
        Explain.RichTextBox1.AppendText("[REM]:Remote elevation measurement" & vbCrLf)
        Explain.RichTextBox1.AppendText("[RESEC]	: Recection measurement (The instrument station coordinate can be recorded on the measurement result screen.)" & vbCrLf)
        Explain.RichTextBox1.AppendText("[R/L]	:   Select horizontal angle right/left" & vbCrLf)
        Explain.RichTextBox1.AppendText("[ZA / %]	: Switch between zenith angle/slope in %" & vbCrLf)
        Explain.RichTextBox1.AppendText(" [HOLD]	: Hold horizontal angle/release horizontal angle" & vbCrLf)
        Explain.RichTextBox1.AppendText("[CALL]	: Display final measurement data" & vbCrLf)
        Explain.RichTextBox1.AppendText("[S-LEV]	: Return signal" & vbCrLf)
        Explain.RichTextBox1.AppendText("[AREA]	:   Surface area measurement" & vbCrLf)
        Explain.RichTextBox1.AppendText("[F/M]	:   Switch between meters/feet" & vbCrLf)
        Explain.RichTextBox1.AppendText("[HT]	: Set the instrument station height and target height" & vbCrLf)
        Explain.RichTextBox1.AppendText("[S-O LINE] :  Setting-out line measurement" & vbCrLf)
        Explain.RichTextBox1.AppendText(" [S-O ARC] : Setting-out arc measurement " & vbCrLf)
        Explain.RichTextBox1.AppendText("[P-PROJ] :  Point projection measurement" & vbCrLf)
        Explain.RichTextBox1.AppendText(" [PTL]	: PT to Line" & vbCrLf)
        Explain.RichTextBox1.AppendText("[INTSCT]: Intersections(measurement)" & vbCrLf)
        Explain.RichTextBox1.AppendText("[TRAV]: Traverse(adjustment)" & vbCrLf)
        Explain.RichTextBox1.AppendText("[ROAD]: Route(surveying)" & vbCrLf)
        Explain.RichTextBox1.AppendText("[X SECT]	: Cross section survey" & vbCrLf)
        Explain.RichTextBox1.AppendText("[TOPOII]: Topography(observation)" & vbCrLf)
        Explain.RichTextBox1.AppendText("[L-PLUM]	: Brightness configuration for laser plummet" & vbCrLf)
        Explain.RichTextBox1.AppendText("[HVDOUT-T] / [HVDOUT-S]: Output distance/angle measurement results to an external instrument" & vbCrLf)
        Explain.RichTextBox1.AppendText("[HVOUT-T] / [HVOUT-S]: Output angle measurement results to an external instrument" & vbCrLf)
        Explain.RichTextBox1.AppendText("[NEZOUT-T] / [NEZOUT-S]: Output the coordinate results to an external instrument" & vbCrLf)
        Explain.RichTextBox1.AppendText("[---]	: No functions set" & vbCrLf)
    End Sub
End Class
