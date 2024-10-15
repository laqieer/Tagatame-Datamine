// Decompiled with JetBrains decompiler
// Type: SRPG.ConfigPremiumLoginBonusButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002252")]
  public class ConfigPremiumLoginBonusButton : MonoBehaviour
  {
    [Token(Token = "0x400984A")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    public string productID;
    [Token(Token = "0x400984B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public GameObject on;
    [Token(Token = "0x400984C")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public GameObject off;

    [Token(Token = "0x600924B")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ConfigPremiumLoginBonusButton()
    {
    }
  }
}
