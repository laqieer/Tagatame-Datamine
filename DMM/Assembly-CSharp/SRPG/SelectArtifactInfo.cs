// Decompiled with JetBrains decompiler
// Type: SRPG.SelectArtifactInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002A7E")]
  [AddComponentMenu("UI/SelectArtifactInfo")]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  public class SelectArtifactInfo : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400CEDA")]
    [FieldOffset(Offset = "0xC")]
    public GameObject AbilityListItem;
    [Token(Token = "0x400CEDB")]
    [FieldOffset(Offset = "0x10")]
    public float ability_unlock_alpha;
    [Token(Token = "0x400CEDC")]
    [FieldOffset(Offset = "0x14")]
    public float ability_hidden_alpha;
    [Token(Token = "0x400CEDD")]
    [FieldOffset(Offset = "0x18")]
    public GameObject lock_object;

    [Token(Token = "0x600C205")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C206")]
    [Address(RVA = "0x8A69B0", Offset = "0x8A57B0", VA = "0x108A69B0")]
    private void Start()
    {
    }

    [Token(Token = "0x600C207")]
    [Address(RVA = "0x8A64D0", Offset = "0x8A52D0", VA = "0x108A64D0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C208")]
    [Address(RVA = "0x8A64F0", Offset = "0x8A52F0", VA = "0x108A64F0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600C209")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public SelectArtifactInfo()
    {
    }
  }
}
