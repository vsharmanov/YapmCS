﻿' =======================================================
' Yet Another (remote) Process Monitor (YAPM)
' Copyright (c) 2008-2009 Alain Descotes (violent_ken)
' https://sourceforge.net/projects/yaprocmon/
' =======================================================


' YAPM is free software; you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation; either version 3 of the License, or
' (at your option) any later version.
'
' YAPM is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License
' along with YAPM; if not, see http://www.gnu.org/licenses/.

Option Strict On

Imports System.Runtime.InteropServices
Imports System.Text
Imports Native.Api

Namespace Native.Objects

    Public Class File

        ' ========================================
        ' Private constants
        ' ========================================


        ' ========================================
        ' Private attributes
        ' ========================================


        ' ========================================
        ' Public properties
        ' ========================================


        ' ========================================
        ' Public functions
        ' ========================================

        ''' <summary>
        ' Retrieve a resource from a file
        ' The file must looks like @%systemroot%\xxx\yy.exe, 5
        ''' </summary>
        Public Shared Function GetResourceStringFromFile(ByVal filePath As String) As String

            ' Windows dir
            Dim rootDir As String = _
                    System.Environment.GetFolderPath(Environment.SpecialFolder.System)

            ' Insert Windows dir in path
            Dim s As String = filePath.ToUpperInvariant.Replace("@%SYSTEMROOT%", rootDir)
            s = s.ToUpperInvariant.Replace("%SYSTEMROOT%", rootDir)


            ' Get pos of extension
            Dim i As Integer = s.IndexOf(".EXE")
            If i <= 0 Then
                ' Dll ?
                i = s.IndexOf(".DLL")
                If i <= 0 Then
                    ' SYS ?
                    i = s.IndexOf(".SYS")
                End If
            End If

            ' Get ID and File
            Dim iD As UInteger
            Dim file As String
            file = s.Substring(0, s.Length - 3)
            Try
                iD = UInteger.Parse(s.Substring(i + 6, s.Length - i - 6))
                ' Get resource
                Return Common.Misc.FormatPathWithDoubleSlashs(GetResourceStringFromFile(file, iD))
            Catch ex As Exception
                Return ""
            End Try


        End Function

        ' Retrieve a resource from a file
        Public Shared Function GetResourceStringFromFile(ByVal file As String, _
                                                          ByVal id As UInteger) As String
            Dim hInst As IntPtr = NativeFunctions.LoadLibrary(file)
            Dim sb As New StringBuilder(1024)
            NativeFunctions.LoadString(hInst, id, sb, sb.Capacity)
            NativeFunctions.FreeLibrary(hInst)
            Return sb.ToString
        End Function


        ' ========================================
        ' Private functions
        ' ========================================


    End Class

End Namespace
