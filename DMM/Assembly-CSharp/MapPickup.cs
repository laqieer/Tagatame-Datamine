// Decompiled with JetBrains decompiler
// Type: MapPickup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000013")]
[AddComponentMenu("Battle/MapPickup")]
public class MapPickup : MonoBehaviour
{
  [Token(Token = "0x4000051")]
  [FieldOffset(Offset = "0xC")]
  public MapPickup.PickupEvent OnPickup;
  [Token(Token = "0x4000052")]
  [FieldOffset(Offset = "0x10")]
  public Transform Shadow;
  [Token(Token = "0x4000053")]
  [FieldOffset(Offset = "0x14")]
  public Vector3 DropEffectOffset;

  [Token(Token = "0x6000075")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public MapPickup()
  {
  }

  [Token(Token = "0x2000014")]
  public delegate void PickupEvent();
}
