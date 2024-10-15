// Decompiled with JetBrains decompiler
// Type: SRPG.UnitStatusAwakeContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002CFC")]
  public class UnitStatusAwakeContent : MonoBehaviour
  {
    [Token(Token = "0x400DFAD")]
    private const string SVB_KEY_BULK_SELECT_NUM = "SVB_KEY_BULK_SELECT_NUM";
    [Token(Token = "0x400DFAE")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    public ItemIcon Icon;
    [Token(Token = "0x400DFAF")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public Slider SliderData;
    [Token(Token = "0x400DFB0")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public SRPG_Button PlusBtn;
    [Token(Token = "0x400DFB1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public SRPG_Button MinusBtn;
    [Token(Token = "0x400DFB2")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public Toggle MaxCheckToggle;
    [Token(Token = "0x400DFB3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public SRPG_Button BulkUpBtn1;
    [Token(Token = "0x400DFB4")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public Text BulkUpText1;
    [Token(Token = "0x400DFB5")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public SRPG_Button BulkUpBtn2;
    [Token(Token = "0x400DFB6")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public Text BulkUpText2;
    [Token(Token = "0x400DFB7")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public Text UseNum;
    [Token(Token = "0x400DFB8")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public Text UsedNum;
    [Token(Token = "0x400DFB9")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public GameObject Mask;

    [Token(Token = "0x17001B7F")]
    public ItemData Item
    {
      [Token(Token = "0x600D165"), Address(RVA = "0x288010", Offset = "0x286E10", VA = "0x10288010")] get
      {
        return (ItemData) null;
      }
      [Token(Token = "0x600D166"), Address(RVA = "0x36F610", Offset = "0x36E410", VA = "0x1036F610")] private set
      {
      }
    }

    [Token(Token = "0x17001B80")]
    public int SelectNum
    {
      [Token(Token = "0x600D167"), Address(RVA = "0x34EDB0", Offset = "0x34DBB0", VA = "0x1034EDB0")] get
      {
        return new int();
      }
      [Token(Token = "0x600D168"), Address(RVA = "0x56B300", Offset = "0x56A100", VA = "0x1056B300")] private set
      {
      }
    }

    [Token(Token = "0x17001B81")]
    public int CreateIndex
    {
      [Token(Token = "0x600D169"), Address(RVA = "0x2880B0", Offset = "0x286EB0", VA = "0x102880B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600D16A"), Address(RVA = "0x56B2E0", Offset = "0x56A0E0", VA = "0x1056B2E0")] private set
      {
      }
    }

    [Token(Token = "0x600D16B")]
    [Address(RVA = "0x9C4970", Offset = "0x9C3770", VA = "0x109C4970")]
    public void Setup(UnitData _unit, ItemData _item, int _create_index)
    {
    }

    [Token(Token = "0x600D16C")]
    [Address(RVA = "0x9C48F0", Offset = "0x9C36F0", VA = "0x109C48F0")]
    public void SetUseItemNum(int use_num)
    {
    }

    [Token(Token = "0x600D16D")]
    [Address(RVA = "0x9C46E0", Offset = "0x9C34E0", VA = "0x109C46E0")]
    public int GetBulkSelectValue(SRPG_Button go, Text txt) => new int();

    [Token(Token = "0x600D16E")]
    [Address(RVA = "0x9C48A0", Offset = "0x9C36A0", VA = "0x109C48A0")]
    public void SetMask(bool is_enable)
    {
    }

    [Token(Token = "0x600D16F")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public UnitStatusAwakeContent()
    {
    }
  }
}
