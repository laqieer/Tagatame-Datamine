// Decompiled with JetBrains decompiler
// Type: SRPG.RoomPlayerViewer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002967")]
  [AddComponentMenu("UI/RoomPlayerViewer")]
  public class RoomPlayerViewer : MonoBehaviour
  {
    [Token(Token = "0x400C785")]
    [FieldOffset(Offset = "0xC")]
    public GameObject[] PartyUnitSlots;

    [Token(Token = "0x600BB43")]
    [Address(RVA = "0x8301F0", Offset = "0x82EFF0", VA = "0x108301F0")]
    private void Start()
    {
    }

    [Token(Token = "0x600BB44")]
    [Address(RVA = "0x830470", Offset = "0x82F270", VA = "0x10830470")]
    public RoomPlayerViewer()
    {
    }
  }
}
