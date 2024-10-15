// Decompiled with JetBrains decompiler
// Type: SRPG.ArenaPlayerInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FD9")]
  [AddComponentMenu("UI/ArenaPlayerInfo")]
  public class ArenaPlayerInfo : MonoBehaviour
  {
    [Token(Token = "0x4008708")]
    [FieldOffset(Offset = "0xC")]
    [Space(10f)]
    public GameObject unit1;
    [Token(Token = "0x4008709")]
    [FieldOffset(Offset = "0x10")]
    public GameObject unit2;
    [Token(Token = "0x400870A")]
    [FieldOffset(Offset = "0x14")]
    public GameObject unit3;

    [Token(Token = "0x600832A")]
    [Address(RVA = "0x439940", Offset = "0x438740", VA = "0x10439940")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x600832B")]
    [Address(RVA = "0x439950", Offset = "0x438750", VA = "0x10439950")]
    public void UpdateValue()
    {
    }

    [Token(Token = "0x600832C")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ArenaPlayerInfo()
    {
    }
  }
}
