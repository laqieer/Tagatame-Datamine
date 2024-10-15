// Decompiled with JetBrains decompiler
// Type: SRPG.GuerrillaShopTimeLimit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F7F")]
  [AddComponentMenu("Common/GuerrillaShopTimeLimit")]
  public class GuerrillaShopTimeLimit : MonoBehaviour, IGameParameter
  {
    [Token(Token = "0x4003652")]
    [FieldOffset(Offset = "0xC")]
    public Text Hour;
    [Token(Token = "0x4003653")]
    [FieldOffset(Offset = "0x10")]
    public Text Minute;
    [Token(Token = "0x4003654")]
    [FieldOffset(Offset = "0x14")]
    public Text Second;
    [Token(Token = "0x4003655")]
    [FieldOffset(Offset = "0x18")]
    private long mEndTime;
    [Token(Token = "0x4003656")]
    [FieldOffset(Offset = "0x20")]
    private float mRefreshInterval;

    [Token(Token = "0x600404E")]
    [Address(RVA = "0x1190CC0", Offset = "0x118FAC0", VA = "0x11190CC0")]
    private void Start()
    {
    }

    [Token(Token = "0x600404F")]
    [Address(RVA = "0x1190DD0", Offset = "0x118FBD0", VA = "0x11190DD0")]
    private void Update()
    {
    }

    [Token(Token = "0x6004050")]
    [Address(RVA = "0x11908A0", Offset = "0x118F6A0", VA = "0x111908A0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6004051")]
    [Address(RVA = "0x1190D50", Offset = "0x118FB50", VA = "0x11190D50", Slot = "4")]
    public void UpdateValue()
    {
    }

    [Token(Token = "0x6004052")]
    [Address(RVA = "0x1190E20", Offset = "0x118FC20", VA = "0x11190E20")]
    public GuerrillaShopTimeLimit()
    {
    }
  }
}
