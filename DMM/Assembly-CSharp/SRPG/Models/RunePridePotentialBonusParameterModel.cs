// Decompiled with JetBrains decompiler
// Type: SRPG.Models.RunePridePotentialBonusParameterModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x20033B7")]
  public class RunePridePotentialBonusParameterModel : BaseParameterModel
  {
    [Token(Token = "0x400F4DA")]
    [FieldOffset(Offset = "0x24")]
    private RunePridePotentialSlotData slotData;
    [Token(Token = "0x400F4DB")]
    [FieldOffset(Offset = "0x28")]
    private RunePridePotentialBonusWindow.SlotStatus slotStatus;

    [Token(Token = "0x17002096")]
    public bool OpenedObj
    {
      [Token(Token = "0x600E716"), Address(RVA = "0x2C0B60", Offset = "0x2BF960", VA = "0x102C0B60")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E717"), Address(RVA = "0x4A9DB0", Offset = "0x4A8BB0", VA = "0x104A9DB0")] private set
      {
      }
    }

    [Token(Token = "0x17002097")]
    public bool CanOpenObj
    {
      [Token(Token = "0x600E718"), Address(RVA = "0x34B870", Offset = "0x34A670", VA = "0x1034B870")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E719"), Address(RVA = "0x574130", Offset = "0x572F30", VA = "0x10574130")] private set
      {
      }
    }

    [Token(Token = "0x17002098")]
    public bool LockedObj
    {
      [Token(Token = "0x600E71A"), Address(RVA = "0x39CB50", Offset = "0x39B950", VA = "0x1039CB50")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E71B"), Address(RVA = "0xAC7310", Offset = "0xAC6110", VA = "0x10AC7310")] private set
      {
      }
    }

    [Token(Token = "0x17002099")]
    public bool SelectFrameObj
    {
      [Token(Token = "0x600E71C"), Address(RVA = "0xAB4EA0", Offset = "0xAB3CA0", VA = "0x10AB4EA0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E71D"), Address(RVA = "0xAC7320", Offset = "0xAC6120", VA = "0x10AC7320")] private set
      {
      }
    }

    [Token(Token = "0x600E71E")]
    [Address(RVA = "0xAC7110", Offset = "0xAC5F10", VA = "0x10AC7110")]
    public void Initialize(
      RunePridePotentialSlotData _slotData,
      RunePridePotentialBonusWindow.SlotStatus _slotStatus,
      bool isSelected)
    {
    }

    [Token(Token = "0x600E71F")]
    [Address(RVA = "0xAC7210", Offset = "0xAC6010", VA = "0x10AC7210")]
    public void Initialize(
      RunePridePotentialBonusWindow.SlotStatus _slotStatus,
      bool isSelected)
    {
    }

    [Token(Token = "0x600E720")]
    [Address(RVA = "0xAC7270", Offset = "0xAC6070", VA = "0x10AC7270")]
    private void SetSlotObjectStatus()
    {
    }

    [Token(Token = "0x600E721")]
    [Address(RVA = "0xAC72A0", Offset = "0xAC60A0", VA = "0x10AC72A0")]
    public void UpdateSlotStatus(
      RunePridePotentialBonusWindow.SlotStatus _slotStatus)
    {
    }

    [Token(Token = "0x600E722")]
    [Address(RVA = "0xAC72D0", Offset = "0xAC60D0", VA = "0x10AC72D0")]
    public void UpdateValues(RunePridePotentialSlotData _slotData)
    {
    }

    [Token(Token = "0x600E723")]
    [Address(RVA = "0xAC7250", Offset = "0xAC6050", VA = "0x10AC7250")]
    public void SelectSelf()
    {
    }

    [Token(Token = "0x600E724")]
    [Address(RVA = "0xAC7240", Offset = "0xAC6040", VA = "0x10AC7240")]
    public void ResetSelf()
    {
    }

    [Token(Token = "0x600E725")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RunePridePotentialBonusParameterModel()
    {
    }
  }
}
