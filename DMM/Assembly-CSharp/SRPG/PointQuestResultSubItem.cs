// Decompiled with JetBrains decompiler
// Type: SRPG.PointQuestResultSubItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002837")]
  public class PointQuestResultSubItem : MonoBehaviour
  {
    [Token(Token = "0x400BFCC")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Color PointPlusColor;
    [Token(Token = "0x400BFCD")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Color PointMinusColor;
    [Token(Token = "0x400BFCE")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject SubObj;
    [Token(Token = "0x400BFCF")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text TitleText;
    [Token(Token = "0x400BFD0")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Text PointText;
    [Token(Token = "0x400BFD1")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text UnitText;

    [Token(Token = "0x600B584")]
    [Address(RVA = "0x7BED60", Offset = "0x7BDB60", VA = "0x107BED60")]
    public void SetUp(string _title_key, int _value, string _unit_key)
    {
    }

    [Token(Token = "0x600B585")]
    [Address(RVA = "0x7BED10", Offset = "0x7BDB10", VA = "0x107BED10")]
    public void ActiveObj()
    {
    }

    [Token(Token = "0x600B586")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public PointQuestResultSubItem()
    {
    }
  }
}
