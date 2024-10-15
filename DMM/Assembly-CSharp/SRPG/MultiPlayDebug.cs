// Decompiled with JetBrains decompiler
// Type: SRPG.MultiPlayDebug
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200278B")]
  [AddComponentMenu("UI/MultiPlayDebug")]
  public class MultiPlayDebug : MonoBehaviour
  {
    [Token(Token = "0x400BAC3")]
    [FieldOffset(Offset = "0xC")]
    public GameObject debuginfo;
    [Token(Token = "0x400BAC4")]
    [FieldOffset(Offset = "0x10")]
    public Button m_DebugBtn;
    [Token(Token = "0x400BAC5")]
    [FieldOffset(Offset = "0x14")]
    public bool IsDebugDraw;
    [Token(Token = "0x400BAC6")]
    [FieldOffset(Offset = "0x0")]
    private static MultiPlayDebug mInstance;

    [Token(Token = "0x17001882")]
    public static MultiPlayDebug Instance
    {
      [Token(Token = "0x600B160"), Address(RVA = "0x757500", Offset = "0x756300", VA = "0x10757500")] get
      {
        return (MultiPlayDebug) null;
      }
    }

    [Token(Token = "0x600B161")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600B162")]
    [Address(RVA = "0x7574D0", Offset = "0x7562D0", VA = "0x107574D0")]
    private void Start()
    {
    }

    [Token(Token = "0x600B163")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600B164")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnClick()
    {
    }

    [Token(Token = "0x600B165")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public MultiPlayDebug()
    {
    }
  }
}
