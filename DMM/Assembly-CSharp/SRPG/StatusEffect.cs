// Decompiled with JetBrains decompiler
// Type: SRPG.StatusEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002AFE")]
  [AddComponentMenu("UI/StatusEffect")]
  public class StatusEffect : MonoBehaviour
  {
    [Token(Token = "0x400D1CC")]
    [FieldOffset(Offset = "0xC")]
    public GameObject[] StatusSlot;
    [Token(Token = "0x400D1CD")]
    [FieldOffset(Offset = "0x10")]
    private bool[] mNowConditions;
    [Token(Token = "0x400D1CE")]
    [FieldOffset(Offset = "0x14")]
    private float mElapsed;
    [Token(Token = "0x400D1CF")]
    [FieldOffset(Offset = "0x18")]
    private int mActiveParamCount;

    [Token(Token = "0x600C4CF")]
    [Address(RVA = "0x8D4130", Offset = "0x8D2F30", VA = "0x108D4130")]
    private void Start()
    {
    }

    [Token(Token = "0x600C4D0")]
    [Address(RVA = "0x8D3CA0", Offset = "0x8D2AA0", VA = "0x108D3CA0")]
    private void Reset()
    {
    }

    [Token(Token = "0x600C4D1")]
    [Address(RVA = "0x8D3E40", Offset = "0x8D2C40", VA = "0x108D3E40")]
    public void SetStatus(Unit unit)
    {
    }

    [Token(Token = "0x600C4D2")]
    [Address(RVA = "0x8D3D20", Offset = "0x8D2B20", VA = "0x108D3D20")]
    private bool SetStatusSlot(int count, int idx) => new bool();

    [Token(Token = "0x600C4D3")]
    [Address(RVA = "0x8D41C0", Offset = "0x8D2FC0", VA = "0x108D41C0")]
    private void Update()
    {
    }

    [Token(Token = "0x600C4D4")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public StatusEffect()
    {
    }

    [Token(Token = "0x2002AFF")]
    public enum eOtherStatus
    {
      [Token(Token = "0x400D1D1")] SHIELD,
      [Token(Token = "0x400D1D2")] FORCED_TARGETING,
      [Token(Token = "0x400D1D3")] BE_FORCED_TARGETED,
      [Token(Token = "0x400D1D4")] PROTECT,
      [Token(Token = "0x400D1D5")] GUARD,
      [Token(Token = "0x400D1D6")] SKILL_DISTANCE_PLUS,
      [Token(Token = "0x400D1D7")] SKILL_DISTANCE_MINUS,
      [Token(Token = "0x400D1D8")] MAX,
    }
  }
}
