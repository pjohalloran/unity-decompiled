﻿// Decompiled with JetBrains decompiler
// Type: UnityEditor.Connect.ConnectInfo
// Assembly: UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 01B28312-B6F5-4E06-90F6-BE297B711E41
// Assembly location: C:\Users\Blake\sandbox\unity\test-project\Library\UnityAssemblies\UnityEditor.dll

namespace UnityEditor.Connect
{
  internal struct ConnectInfo
  {
    private int m_Initialized;
    private int m_Ready;
    private int m_Online;
    private int m_LoggedIn;
    private int m_WorkOffline;
    private int m_ShowLoginWindow;
    private int m_Error;
    private int m_Maintenance;

    public bool initialized
    {
      get
      {
        return this.m_Initialized != 0;
      }
    }

    public bool ready
    {
      get
      {
        return this.m_Ready != 0;
      }
    }

    public bool online
    {
      get
      {
        return this.m_Online != 0;
      }
    }

    public bool loggedIn
    {
      get
      {
        return this.m_LoggedIn != 0;
      }
    }

    public bool workOffline
    {
      get
      {
        return this.m_WorkOffline != 0;
      }
    }

    public bool showLoginWindow
    {
      get
      {
        return this.m_ShowLoginWindow != 0;
      }
    }

    public bool error
    {
      get
      {
        return this.m_Error != 0;
      }
    }

    public bool maintenance
    {
      get
      {
        return this.m_Maintenance != 0;
      }
    }
  }
}