// Decompiled with JetBrains decompiler
// Type: SRPG.VersusTowerFloor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002756")]
  [AddComponentMenu("UI/Multi/Versus/VersusTowerFloor")]
  public class VersusTowerFloor : MonoBehaviour
  {
    [Token(Token = "0x400B9AF")]
    [FieldOffset(Offset = "0xC")]
    public Text FriendName;
    [Token(Token = "0x400B9B0")]
    [FieldOffset(Offset = "0x10")]
    public Text FloorText;
    [Token(Token = "0x400B9B1")]
    [FieldOffset(Offset = "0x14")]
    public GameObject UnitObj;
    [Token(Token = "0x400B9B2")]
    [FieldOffset(Offset = "0x18")]
    public GameObject FloorInfoObj;
    [Token(Token = "0x400B9B3")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject RingObj;
    [Token(Token = "0x400B9B4")]
    [FieldOffset(Offset = "0x20")]
    public Sprite CurrentSprite;
    [Token(Token = "0x400B9B5")]
    [FieldOffset(Offset = "0x24")]
    public Sprite DefaultSprite;
    [Token(Token = "0x400B9B6")]
    [FieldOffset(Offset = "0x28")]
    public Image FloorImage;
    [Token(Token = "0x400B9B7")]
    [FieldOffset(Offset = "0x2C")]
    private int mCurrentFloor;

    [Token(Token = "0x17001859")]
    public int Floor
    {
      [Token(Token = "0x600B081"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600B082")]
    [Address(RVA = "0x7521B0", Offset = "0x750FB0", VA = "0x107521B0")]
    public void Refresh(int idx, int max)
    {
    }

    [Token(Token = "0x600B083")]
    [Address(RVA = "0x752750", Offset = "0x751550", VA = "0x10752750")]
    public void SetPlayerObject(GameObject playerObj)
    {
    }

    [Token(Token = "0x600B084")]
    [Address(RVA = "0x752850", Offset = "0x751650", VA = "0x10752850")]
    public VersusTowerFloor()
    {
    }
  }
}
