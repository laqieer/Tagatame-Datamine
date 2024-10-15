// Decompiled with JetBrains decompiler
// Type: SRPG.TabMaker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B21")]
  [AddComponentMenu("UI/TabMaker")]
  public class TabMaker : MonoBehaviour
  {
    [Token(Token = "0x400D27F")]
    [FieldOffset(Offset = "0xC")]
    public SerializeValueBehaviour m_TabNode;
    [Token(Token = "0x400D280")]
    [FieldOffset(Offset = "0x10")]
    public Sprite m_CornerSpriteOff;
    [Token(Token = "0x400D281")]
    [FieldOffset(Offset = "0x14")]
    public Sprite m_CornerSpriteOn;
    [Token(Token = "0x400D282")]
    [FieldOffset(Offset = "0x18")]
    public Sprite m_SpriteOff;
    [Token(Token = "0x400D283")]
    [FieldOffset(Offset = "0x1C")]
    public Sprite m_SpriteOn;
    [Token(Token = "0x400D284")]
    [FieldOffset(Offset = "0x20")]
    public TabMaker.Element[] m_Elements;
    [Token(Token = "0x400D285")]
    [FieldOffset(Offset = "0x24")]
    private List<TabMaker.Info> m_InfoList;

    [Token(Token = "0x600C55C")]
    [Address(RVA = "0x8DEC10", Offset = "0x8DDA10", VA = "0x108DEC10")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C55D")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Start()
    {
    }

    [Token(Token = "0x600C55E")]
    [Address(RVA = "0x8DF7D0", Offset = "0x8DE5D0", VA = "0x108DF7D0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600C55F")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Update()
    {
    }

    [Token(Token = "0x600C560")]
    [Address(RVA = "0x8DEC90", Offset = "0x8DDA90", VA = "0x108DEC90")]
    public void Create(string[] keys, Action<GameObject, SerializeValueList> callback)
    {
    }

    [Token(Token = "0x600C561")]
    [Address(RVA = "0x8DF4C0", Offset = "0x8DE2C0", VA = "0x108DF4C0")]
    public void Destroy()
    {
    }

    [Token(Token = "0x600C562")]
    [Address(RVA = "0x8DF5D0", Offset = "0x8DE3D0", VA = "0x108DF5D0")]
    public TabMaker.Element GetElement(string key) => (TabMaker.Element) null;

    [Token(Token = "0x600C563")]
    [Address(RVA = "0x8DF700", Offset = "0x8DE500", VA = "0x108DF700")]
    public TabMaker.Info[] GetInfos() => (TabMaker.Info[]) null;

    [Token(Token = "0x600C564")]
    [Address(RVA = "0x8DF660", Offset = "0x8DE460", VA = "0x108DF660")]
    public TabMaker.Info GetInfo(string key) => (TabMaker.Info) null;

    [Token(Token = "0x600C565")]
    [Address(RVA = "0x8DF740", Offset = "0x8DE540", VA = "0x108DF740")]
    public TabMaker.Info GetOnIfno() => (TabMaker.Info) null;

    [Token(Token = "0x600C566")]
    [Address(RVA = "0x8DF830", Offset = "0x8DE630", VA = "0x108DF830")]
    public void SetOn(string key, bool value)
    {
    }

    [Token(Token = "0x600C567")]
    [Address(RVA = "0x8DF7E0", Offset = "0x8DE5E0", VA = "0x108DF7E0")]
    public void SetOn(Enum key, bool value)
    {
    }

    [Token(Token = "0x600C568")]
    [Address(RVA = "0x8DF860", Offset = "0x8DE660", VA = "0x108DF860")]
    public TabMaker()
    {
    }

    [Token(Token = "0x2002B22")]
    [Serializable]
    public class Element
    {
      [Token(Token = "0x400D286")]
      [FieldOffset(Offset = "0x8")]
      public string key;
      [Token(Token = "0x400D287")]
      [FieldOffset(Offset = "0xC")]
      public Sprite icon;
      [Token(Token = "0x400D288")]
      [FieldOffset(Offset = "0x10")]
      public string text;
      [Token(Token = "0x400D289")]
      [FieldOffset(Offset = "0x14")]
      public int value;

      [Token(Token = "0x600C569")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Element()
      {
      }
    }

    [Token(Token = "0x2002B23")]
    public class Info
    {
      [Token(Token = "0x400D28A")]
      [FieldOffset(Offset = "0x8")]
      public GameObject node;
      [Token(Token = "0x400D28B")]
      [FieldOffset(Offset = "0xC")]
      public SerializeValueList values;
      [Token(Token = "0x400D28C")]
      [FieldOffset(Offset = "0x10")]
      public TabMaker.Element element;
      [Token(Token = "0x400D28D")]
      [FieldOffset(Offset = "0x14")]
      public Toggle tgl;
      [Token(Token = "0x400D28E")]
      [FieldOffset(Offset = "0x18")]
      public ButtonEvent ev;

      [Token(Token = "0x17001A3A")]
      public bool interactable
      {
        [Token(Token = "0x600C56A"), Address(RVA = "0x8D0C80", Offset = "0x8CFA80", VA = "0x108D0C80")] set
        {
        }
        [Token(Token = "0x600C56B"), Address(RVA = "0x8D0BA0", Offset = "0x8CF9A0", VA = "0x108D0BA0")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x17001A3B")]
      public bool isOn
      {
        [Token(Token = "0x600C56C"), Address(RVA = "0x8D0CF0", Offset = "0x8CFAF0", VA = "0x108D0CF0")] set
        {
        }
        [Token(Token = "0x600C56D"), Address(RVA = "0x8D0C10", Offset = "0x8CFA10", VA = "0x108D0C10")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x600C56E")]
      [Address(RVA = "0x8D0AE0", Offset = "0x8CF8E0", VA = "0x108D0AE0")]
      public Info(GameObject _node, SerializeValueList _values, TabMaker.Element _element)
      {
      }

      [Token(Token = "0x600C56F")]
      [Address(RVA = "0x8D08E0", Offset = "0x8CF6E0", VA = "0x108D08E0")]
      public void SetColor(Color color)
      {
      }
    }
  }
}
