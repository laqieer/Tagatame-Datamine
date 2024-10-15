// Decompiled with JetBrains decompiler
// Type: SRPG.UnitTobiraItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D19")]
  [AddComponentMenu("UI/UnitTobiraItem")]
  public class UnitTobiraItem : MonoBehaviour
  {
    [Token(Token = "0x400E08A")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject DisableGO;
    [Token(Token = "0x400E08B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject EnableGO;
    [Token(Token = "0x400E08C")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject[] LevelIconGOList;
    [Token(Token = "0x400E08D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject SelectedGO;
    [Token(Token = "0x400E08E")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject LockGO;
    [Token(Token = "0x400E08F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ImageArray TobiraEnableImages;
    [Token(Token = "0x400E090")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private ImageArray TobiraDisableImages;
    [Token(Token = "0x400E091")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject HilightGo;
    [Token(Token = "0x400E092")]
    [FieldOffset(Offset = "0x2C")]
    private UnitData mUnit;
    [Token(Token = "0x400E093")]
    [FieldOffset(Offset = "0x30")]
    private TobiraParam.Category mCategory;
    [Token(Token = "0x400E094")]
    [FieldOffset(Offset = "0x34")]
    private TobiraParam mParam;

    [Token(Token = "0x17001B8F")]
    public TobiraParam.Category Category
    {
      [Token(Token = "0x600D208"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return new TobiraParam.Category();
      }
    }

    [Token(Token = "0x17001B90")]
    public TobiraParam Param
    {
      [Token(Token = "0x600D209"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (TobiraParam) null;
      }
    }

    [Token(Token = "0x600D20A")]
    [Address(RVA = "0x9D1090", Offset = "0x9CFE90", VA = "0x109D1090")]
    public void Initialize(UnitData unit, TobiraParam.Category category)
    {
    }

    [Token(Token = "0x600D20B")]
    [Address(RVA = "0x9D1100", Offset = "0x9CFF00", VA = "0x109D1100")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600D20C")]
    [Address(RVA = "0x9D14B0", Offset = "0x9D02B0", VA = "0x109D14B0")]
    public void Select(bool select)
    {
    }

    [Token(Token = "0x600D20D")]
    [Address(RVA = "0x9D1570", Offset = "0x9D0370", VA = "0x109D1570")]
    private void SetHilightAnimationEnable(bool isEnable)
    {
    }

    [Token(Token = "0x600D20E")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public UnitTobiraItem()
    {
    }
  }
}
