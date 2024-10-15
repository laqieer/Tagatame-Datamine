// Decompiled with JetBrains decompiler
// Type: SRPG.SimpleArtifactIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002AB9")]
  [AddComponentMenu("UI/SimpleArtifactIcon")]
  public class SimpleArtifactIcon : BaseIcon
  {
    [Token(Token = "0x400D06F")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text Num;
    [Token(Token = "0x400D070")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text HaveNum;

    [Token(Token = "0x600C31F")]
    [Address(RVA = "0x8B8220", Offset = "0x8B7020", VA = "0x108B8220", Slot = "12")]
    public override void UpdateValue()
    {
    }

    [Token(Token = "0x600C320")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public SimpleArtifactIcon()
    {
    }
  }
}
