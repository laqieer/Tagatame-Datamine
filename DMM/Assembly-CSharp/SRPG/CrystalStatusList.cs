// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalStatusList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200229F")]
  public class CrystalStatusList : MonoBehaviour
  {
    [Token(Token = "0x40099C8")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private CrystalStatusItem ItemTemplate;
    [Token(Token = "0x40099C9")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Transform Parent;
    [Token(Token = "0x40099CA")]
    [FieldOffset(Offset = "0x14")]
    private List<CrystalStatusItem> mItemList;

    [Token(Token = "0x6009442")]
    [Address(RVA = "0x573BB0", Offset = "0x5729B0", VA = "0x10573BB0")]
    private void Start()
    {
    }

    [Token(Token = "0x6009443")]
    [Address(RVA = "0x5738D0", Offset = "0x5726D0", VA = "0x105738D0")]
    public void CreateStatusListOnce(CrystalData _crystal_data)
    {
    }

    [Token(Token = "0x6009444")]
    [Address(RVA = "0x5732D0", Offset = "0x5720D0", VA = "0x105732D0")]
    public void CreateEquipStatusList(
      UnitData _data,
      List<ParamTypes> _active_status,
      bool _is_active)
    {
    }

    [Token(Token = "0x6009445")]
    [Address(RVA = "0x5733D0", Offset = "0x5721D0", VA = "0x105733D0")]
    private void CreateList(
      CrystalStatusList.CrystalStatusListCreateData _data)
    {
    }

    [Token(Token = "0x6009446")]
    [Address(RVA = "0x573A00", Offset = "0x572800", VA = "0x10573A00")]
    public void ListClear()
    {
    }

    [Token(Token = "0x6009447")]
    [Address(RVA = "0x572E70", Offset = "0x571C70", VA = "0x10572E70")]
    private void AddStatusItem(
      ParamTypes _type,
      int _value,
      string _tag,
      bool _is_limit,
      UnitData _unit_data,
      bool _is_limit_add = false)
    {
    }

    [Token(Token = "0x6009448")]
    [Address(RVA = "0x572FC0", Offset = "0x571DC0", VA = "0x10572FC0")]
    private void AddTokkouTokubouParam(
      CrystalStatusList.CrystalStatusListCreateData _data,
      ParamTypes _type)
    {
    }

    [Token(Token = "0x6009449")]
    [Address(RVA = "0x573C00", Offset = "0x572A00", VA = "0x10573C00")]
    public CrystalStatusList()
    {
    }

    [Token(Token = "0x20022A0")]
    private class CrystalStatusListCreateData
    {
      [Token(Token = "0x40099CB")]
      [FieldOffset(Offset = "0x8")]
      public BaseStatus status;
      [Token(Token = "0x40099CC")]
      [FieldOffset(Offset = "0xC")]
      public UnitData unit_data;
      [Token(Token = "0x40099CD")]
      [FieldOffset(Offset = "0x10")]
      public bool is_limit;
      [Token(Token = "0x40099CE")]
      [FieldOffset(Offset = "0x14")]
      public List<ParamTypes> active_status;
      [Token(Token = "0x40099CF")]
      [FieldOffset(Offset = "0x18")]
      public bool is_active;
      [Token(Token = "0x40099D0")]
      [FieldOffset(Offset = "0x1C")]
      public List<CrystalAddLimitStatus> limit_add_list;

      [Token(Token = "0x600944A")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public CrystalStatusListCreateData()
      {
      }
    }
  }
}
