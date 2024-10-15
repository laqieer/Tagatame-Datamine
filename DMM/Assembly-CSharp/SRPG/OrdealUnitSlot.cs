// Decompiled with JetBrains decompiler
// Type: SRPG.OrdealUnitSlot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20027C8")]
  [AddComponentMenu("UI/OrdealUnitSlot")]
  public class OrdealUnitSlot : MonoBehaviour
  {
    [Token(Token = "0x400BC7D")]
    [FieldOffset(Offset = "0xC")]
    public GameObject Leader;
    [Token(Token = "0x400BC7E")]
    [FieldOffset(Offset = "0x10")]
    public GameObject Support;
    [Token(Token = "0x400BC7F")]
    [FieldOffset(Offset = "0x14")]
    public GameObject Lock;
    [Token(Token = "0x400BC80")]
    [FieldOffset(Offset = "0x18")]
    public GameObject Unit;

    [Token(Token = "0x600B2D3")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public OrdealUnitSlot()
    {
    }
  }
}
