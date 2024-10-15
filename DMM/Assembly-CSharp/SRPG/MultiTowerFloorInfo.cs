// Decompiled with JetBrains decompiler
// Type: SRPG.MultiTowerFloorInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20027A6")]
  [AddComponentMenu("UI/MultiTowerFloorInfo")]
  public class MultiTowerFloorInfo : MonoBehaviour
  {
    [Token(Token = "0x400BB53")]
    [FieldOffset(Offset = "0xC")]
    public GameObject Lock;
    [Token(Token = "0x400BB54")]
    [FieldOffset(Offset = "0x10")]
    public GameObject Clear;
    [Token(Token = "0x400BB55")]
    [FieldOffset(Offset = "0x14")]
    public Text Floor;
    [Token(Token = "0x400BB56")]
    [FieldOffset(Offset = "0x18")]
    public SRPG_Button Root;
    [Token(Token = "0x400BB57")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject mBody;
    [Token(Token = "0x400BB58")]
    [FieldOffset(Offset = "0x20")]
    private RectTransform mBodyTransform;
    [Token(Token = "0x400BB59")]
    [FieldOffset(Offset = "0x24")]
    public RectTransform rectTransform;
    [Token(Token = "0x400BB5A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ImageArray[] mBanner;
    [Token(Token = "0x400BB5B")]
    [FieldOffset(Offset = "0x2C")]
    public CanvasRenderer Source;
    [Token(Token = "0x400BB5C")]
    [FieldOffset(Offset = "0x30")]
    private Color UnknownColor;
    [Token(Token = "0x400BB5D")]
    [FieldOffset(Offset = "0x40")]
    public MultiTowerInfo MultiTower;
    [Token(Token = "0x400BB5E")]
    [FieldOffset(Offset = "0x44")]
    public GameObject[] NowCharengeFloor;

    [Token(Token = "0x600B1FF")]
    [Address(RVA = "0x7628E0", Offset = "0x7616E0", VA = "0x107628E0")]
    public void Start()
    {
    }

    [Token(Token = "0x600B200")]
    [Address(RVA = "0x762040", Offset = "0x760E40", VA = "0x10762040")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600B201")]
    [Address(RVA = "0x762580", Offset = "0x761380", VA = "0x10762580")]
    private void SetVisible(MultiTowerFloorInfo.Type type)
    {
    }

    [Token(Token = "0x600B202")]
    [Address(RVA = "0x761F90", Offset = "0x760D90", VA = "0x10761F90")]
    public void OnFocus(bool value)
    {
    }

    [Token(Token = "0x600B203")]
    [Address(RVA = "0x762510", Offset = "0x761310", VA = "0x10762510")]
    public void SetFloor()
    {
    }

    [Token(Token = "0x600B204")]
    [Address(RVA = "0x762300", Offset = "0x761100", VA = "0x10762300")]
    public void SetFloorInfo(
      MultiTowerFloorParam param,
      int challenge,
      int cleared,
      int min_floor = 2147483647)
    {
    }

    [Token(Token = "0x600B205")]
    [Address(RVA = "0x7629F0", Offset = "0x7617F0", VA = "0x107629F0")]
    public MultiTowerFloorInfo()
    {
    }

    [Token(Token = "0x20027A7")]
    private enum Type
    {
      [Token(Token = "0x400BB60")] Locked,
      [Token(Token = "0x400BB61")] Cleared,
      [Token(Token = "0x400BB62")] Current,
      [Token(Token = "0x400BB63")] Unknown,
      [Token(Token = "0x400BB64")] PartnerLocked,
      [Token(Token = "0x400BB65")] TypeEnd,
    }
  }
}
