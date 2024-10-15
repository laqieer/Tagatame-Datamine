// Decompiled with JetBrains decompiler
// Type: SRPG.StatusList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B00")]
  [AddComponentMenu("UI/StatusList")]
  public class StatusList : MonoBehaviour
  {
    [Token(Token = "0x400D1D9")]
    [FieldOffset(Offset = "0xC")]
    public StatusListItem ListItem;
    [Token(Token = "0x400D1DA")]
    [FieldOffset(Offset = "0x10")]
    public bool ShowSign;
    [Token(Token = "0x400D1DB")]
    [FieldOffset(Offset = "0x11")]
    public bool IsChangeTextColor;
    [Token(Token = "0x400D1DC")]
    [FieldOffset(Offset = "0x14")]
    private List<StatusListItem> mItems;
    [Token(Token = "0x400D1DD")]
    [FieldOffset(Offset = "0x18")]
    private Color mDefaultValueColor;
    [Token(Token = "0x400D1DE")]
    [FieldOffset(Offset = "0x28")]
    private Color mDefaultBonusColor;

    [Token(Token = "0x600C4D5")]
    [Address(RVA = "0x8D4DC0", Offset = "0x8D3BC0", VA = "0x108D4DC0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C4D6")]
    [Address(RVA = "0x8D8540", Offset = "0x8D7340", VA = "0x108D8540")]
    private void Start()
    {
    }

    [Token(Token = "0x600C4D7")]
    [Address(RVA = "0x8D7E40", Offset = "0x8D6C40", VA = "0x108D7E40")]
    public void SetValues(
      BaseStatus paramAdd,
      BaseStatus paramMul,
      BaseStatus modAdd,
      BaseStatus modMul,
      bool isSecret = false)
    {
    }

    [Token(Token = "0x600C4D8")]
    [Address(RVA = "0x8D8520", Offset = "0x8D7320", VA = "0x108D8520")]
    public void SetValues(BaseStatus paramAdd, BaseStatus paramMul, bool isSecret = false)
    {
    }

    [Token(Token = "0x600C4D9")]
    [Address(RVA = "0x8D5B10", Offset = "0x8D4910", VA = "0x108D5B10")]
    public void SetValuesTypeData(
      BaseStatus _add_status,
      BaseStatus _scale_status,
      List<StatusList.ParamTypeData> _param_list)
    {
    }

    [Token(Token = "0x600C4DA")]
    [Address(RVA = "0x8D4770", Offset = "0x8D3570", VA = "0x108D4770")]
    private void AddValue(
      int index,
      ParamTypes type,
      int value,
      int bonus,
      bool multiply,
      bool isSecret = false,
      bool use_bonus_color = false,
      string str_tk = null)
    {
    }

    [Token(Token = "0x600C4DB")]
    [Address(RVA = "0x8D5340", Offset = "0x8D4140", VA = "0x108D5340")]
    public void SetValuesAfterOnly(
      BaseStatus paramAdd,
      BaseStatus paramMul,
      BaseStatus modAdd,
      BaseStatus modMul,
      bool isSecret = false,
      bool use_bonus_color = false)
    {
    }

    [Token(Token = "0x600C4DC")]
    [Address(RVA = "0x8D6D00", Offset = "0x8D5B00", VA = "0x108D6D00")]
    public void SetValues_TotalAndBonus(
      BaseStatus paramAdd,
      BaseStatus paramMul,
      BaseStatus modAdd,
      BaseStatus modMul,
      BaseStatus paramBonusAdd,
      BaseStatus paramBonusMul,
      BaseStatus modBonusAdd,
      BaseStatus modBonusMul)
    {
    }

    [Token(Token = "0x600C4DD")]
    [Address(RVA = "0x8D4300", Offset = "0x8D3100", VA = "0x108D4300")]
    private void AddValue_TotalAndBonus(
      int index,
      string type,
      int main_value,
      int bonus_value,
      bool is_def_main,
      bool is_def_bonus,
      bool multiply,
      string str_tk = null)
    {
    }

    [Token(Token = "0x600C4DE")]
    [Address(RVA = "0x8D65B0", Offset = "0x8D53B0", VA = "0x108D65B0")]
    public void SetValues_Restrict(
      BaseStatus paramBaseAdd,
      BaseStatus paramBaseMul,
      BaseStatus paramBonusAdd,
      BaseStatus paramBonusMul,
      bool new_param_only)
    {
    }

    [Token(Token = "0x600C4DF")]
    [Address(RVA = "0x8D4F10", Offset = "0x8D3D10", VA = "0x108D4F10")]
    public void SetColor(Color forceTextColor)
    {
    }

    [Token(Token = "0x600C4E0")]
    [Address(RVA = "0x8D5160", Offset = "0x8D3F60", VA = "0x108D5160")]
    public void SetValueColor(Color _color, ParamTypes _type, bool _is_multiply, string _tag)
    {
    }

    [Token(Token = "0x600C4E1")]
    [Address(RVA = "0x8D85E0", Offset = "0x8D73E0", VA = "0x108D85E0")]
    public StatusList()
    {
    }

    [Token(Token = "0x2002B01")]
    public struct ParamTypeData
    {
      [Token(Token = "0x400D1DF")]
      [FieldOffset(Offset = "0x0")]
      public ParamTypes Type;
      [Token(Token = "0x400D1E0")]
      [FieldOffset(Offset = "0x2")]
      public bool IsMultiply;
      [Token(Token = "0x400D1E1")]
      [FieldOffset(Offset = "0x4")]
      public string Tag;
    }

    [Token(Token = "0x2002B02")]
    private class ParamValues
    {
      [Token(Token = "0x400D1E2")]
      [FieldOffset(Offset = "0x8")]
      public bool is_def_main;
      [Token(Token = "0x400D1E3")]
      [FieldOffset(Offset = "0x9")]
      public bool is_def_bonus;
      [Token(Token = "0x400D1E4")]
      [FieldOffset(Offset = "0xC")]
      public int main_value;
      [Token(Token = "0x400D1E5")]
      [FieldOffset(Offset = "0x10")]
      public int bonus_value;

      [Token(Token = "0x600C4E2")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public ParamValues()
      {
      }
    }
  }
}
