// Decompiled with JetBrains decompiler
// Type: SRPG.FlowWindowBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20023C8")]
  public class FlowWindowBase
  {
    [Token(Token = "0x400A19F")]
    [FieldOffset(Offset = "0x8")]
    private FlowWindowController m_Controller;
    [Token(Token = "0x400A1A0")]
    [FieldOffset(Offset = "0xC")]
    protected GameObject m_Window;
    [Token(Token = "0x400A1A1")]
    [FieldOffset(Offset = "0x10")]
    protected Animator m_Animator;
    [Token(Token = "0x400A1A2")]
    [FieldOffset(Offset = "0x14")]
    protected FlowWindowBase.AnimState m_AnimState;
    [Token(Token = "0x400A1A3")]
    [FieldOffset(Offset = "0x18")]
    protected bool m_StartUp;
    [Token(Token = "0x400A1A4")]
    [FieldOffset(Offset = "0x1C")]
    protected List<int> m_Request;
    [Token(Token = "0x400A1A5")]
    [FieldOffset(Offset = "0x20")]
    protected bool m_AnimStart;
    [Token(Token = "0x400A1A6")]
    [FieldOffset(Offset = "0x24")]
    protected int m_FrameCount;
    [Token(Token = "0x400A1A7")]
    [FieldOffset(Offset = "0x28")]
    protected List<IEnumerator> m_TaskReq;
    [Token(Token = "0x400A1A8")]
    [FieldOffset(Offset = "0x2C")]
    protected IEnumerator m_Task;

    [Token(Token = "0x1700158F")]
    public virtual string name
    {
      [Token(Token = "0x6009AFB"), Address(RVA = "0x5F0580", Offset = "0x5EF380", VA = "0x105F0580", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001590")]
    public bool isValid
    {
      [Token(Token = "0x6009AFC"), Address(RVA = "0x5F0530", Offset = "0x5EF330", VA = "0x105F0530")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001591")]
    public bool isOpen
    {
      [Token(Token = "0x6009AFD"), Address(RVA = "0x5F0510", Offset = "0x5EF310", VA = "0x105F0510")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001592")]
    public bool isClose
    {
      [Token(Token = "0x6009AFE"), Address(RVA = "0x5F0500", Offset = "0x5EF300", VA = "0x105F0500")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001593")]
    public bool isOpened
    {
      [Token(Token = "0x6009AFF"), Address(RVA = "0x5F0520", Offset = "0x5EF320", VA = "0x105F0520")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001594")]
    public bool isClosed
    {
      [Token(Token = "0x6009B00"), Address(RVA = "0x3827F0", Offset = "0x3815F0", VA = "0x103827F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6009B01")]
    [Address(RVA = "0x5EFA30", Offset = "0x5EE830", VA = "0x105EFA30", Slot = "5")]
    public virtual void Initialize(FlowWindowBase.SerializeParamBase param)
    {
    }

    [Token(Token = "0x6009B02")]
    [Address(RVA = "0x5EFCD0", Offset = "0x5EEAD0", VA = "0x105EFCD0", Slot = "6")]
    public virtual void Release()
    {
    }

    [Token(Token = "0x6009B03")]
    [Address(RVA = "0x5EFFD0", Offset = "0x5EEDD0", VA = "0x105EFFD0", Slot = "7")]
    public virtual void Start()
    {
    }

    [Token(Token = "0x6009B04")]
    [Address(RVA = "0x5F0220", Offset = "0x5EF020", VA = "0x105F0220")]
    public void Update(FlowWindowController controller)
    {
    }

    [Token(Token = "0x6009B05")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void LateUpdate(FlowNode flowNode)
    {
    }

    [Token(Token = "0x6009B06")]
    [Address(RVA = "0x5F00B0", Offset = "0x5EEEB0", VA = "0x105F00B0", Slot = "8")]
    public virtual int Update() => new int();

    [Token(Token = "0x6009B07")]
    [Address(RVA = "0x5EFCA0", Offset = "0x5EEAA0", VA = "0x105EFCA0")]
    public void Open()
    {
    }

    [Token(Token = "0x6009B08")]
    [Address(RVA = "0x5EF5F0", Offset = "0x5EE3F0", VA = "0x105EF5F0")]
    public void Close(bool immidiate = false)
    {
    }

    [Token(Token = "0x6009B09")]
    [Address(RVA = "0x5EF580", Offset = "0x5EE380", VA = "0x105EF580")]
    private void ClearTask()
    {
    }

    [Token(Token = "0x6009B0A")]
    [Address(RVA = "0x5EF530", Offset = "0x5EE330", VA = "0x105EF530")]
    protected void AddTask(IEnumerator enumrator)
    {
    }

    [Token(Token = "0x6009B0B")]
    [Address(RVA = "0x5EFFE0", Offset = "0x5EEDE0", VA = "0x105EFFE0")]
    public bool UpdateTask() => new bool();

    [Token(Token = "0x6009B0C")]
    [Address(RVA = "0x5EFFD0", Offset = "0x5EEDD0", VA = "0x105EFFD0")]
    public void StartUp()
    {
    }

    [Token(Token = "0x6009B0D")]
    [Address(RVA = "0x5EFEE0", Offset = "0x5EECE0", VA = "0x105EFEE0")]
    public void SetActiveChild(GameObject root, bool value)
    {
    }

    [Token(Token = "0x6009B0E")]
    [Address(RVA = "0x5EFDF0", Offset = "0x5EEBF0", VA = "0x105EFDF0")]
    public void SetActiveChild(bool value)
    {
    }

    [Token(Token = "0x6009B0F")]
    [Address(RVA = "0x5EF8F0", Offset = "0x5EE6F0", VA = "0x105EF8F0")]
    public GameObject GetChild(string name) => (GameObject) null;

    [Token(Token = "0x6009B10")]
    [Address(RVA = "0x5EF910", Offset = "0x5EE710", VA = "0x105EF910")]
    public GameObject GetChild(GameObject root, string name) => (GameObject) null;

    [Token(Token = "0x6009B11")]
    [Address(RVA = "0x5EF8D0", Offset = "0x5EE6D0", VA = "0x105EF8D0")]
    public GameObject GetChildAll(string name) => (GameObject) null;

    [Token(Token = "0x6009B12")]
    [Address(RVA = "0x5EF6D0", Offset = "0x5EE4D0", VA = "0x105EF6D0")]
    public GameObject GetChildAll(GameObject root, string name) => (GameObject) null;

    [Token(Token = "0x6009B13")]
    public T GetChildComponent<T>(GameObject root, string name) where T : Component => (T) null;

    [Token(Token = "0x6009B14")]
    public T GetChildComponent<T>(string name) where T : Component => (T) null;

    [Token(Token = "0x6009B15")]
    public T GetChildAllComponent<T>(string name) where T : Component => (T) null;

    [Token(Token = "0x6009B16")]
    [Address(RVA = "0x3057E0", Offset = "0x3045E0", VA = "0x103057E0")]
    public bool IsStartUp() => new bool();

    [Token(Token = "0x6009B17")]
    [Address(RVA = "0x5EFB20", Offset = "0x5EE920", VA = "0x105EFB20")]
    public bool IsState(string stateName) => new bool();

    [Token(Token = "0x6009B18")]
    [Address(RVA = "0x5EFD70", Offset = "0x5EEB70", VA = "0x105EFD70")]
    public void RequestPin(int pinId)
    {
    }

    [Token(Token = "0x6009B19")]
    [Address(RVA = "0x5EFC90", Offset = "0x5EEA90", VA = "0x105EFC90", Slot = "9")]
    public virtual int OnActivate(int pinId) => new int();

    [Token(Token = "0x6009B1A")]
    [Address(RVA = "0x5EFC90", Offset = "0x5EEA90", VA = "0x105EFC90", Slot = "10")]
    protected virtual int OnOpened() => new int();

    [Token(Token = "0x6009B1B")]
    [Address(RVA = "0x5EFC90", Offset = "0x5EEA90", VA = "0x105EFC90", Slot = "11")]
    protected virtual int OnClosed() => new int();

    [Token(Token = "0x6009B1C")]
    [Address(RVA = "0x5F0450", Offset = "0x5EF250", VA = "0x105F0450")]
    public FlowWindowBase()
    {
    }

    [Token(Token = "0x20023C9")]
    public enum AnimState
    {
      [Token(Token = "0x400A1AA")] IDEL,
      [Token(Token = "0x400A1AB")] OPEN,
      [Token(Token = "0x400A1AC")] CLOSE,
      [Token(Token = "0x400A1AD")] OPENED,
      [Token(Token = "0x400A1AE")] CLOSED,
    }

    [Token(Token = "0x20023CA")]
    [Serializable]
    public class SerializeParamBase
    {
      [Token(Token = "0x400A1AF")]
      [FieldOffset(Offset = "0x8")]
      public GameObject window;

      [Token(Token = "0x17001595")]
      public virtual System.Type type
      {
        [Token(Token = "0x6009B1D"), Address(RVA = "0x5F3F00", Offset = "0x5F2D00", VA = "0x105F3F00", Slot = "4")] get
        {
          return (System.Type) null;
        }
      }

      [Token(Token = "0x6009B1E")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public SerializeParamBase()
      {
      }
    }
  }
}
