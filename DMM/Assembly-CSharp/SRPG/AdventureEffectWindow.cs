// Decompiled with JetBrains decompiler
// Type: SRPG.AdventureEffectWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F98")]
  [AddComponentMenu("UI/Adventure/AdventureEffectWindow")]
  public class AdventureEffectWindow : MonoBehaviour
  {
    [Token(Token = "0x400857E")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject Window;
    [Token(Token = "0x400857F")]
    [FieldOffset(Offset = "0x10")]
    [Space(5f)]
    [SerializeField]
    private Text TextOfStatus;
    [Token(Token = "0x4008580")]
    private const string TextOrder = "sys.ADVENTURE_QUEST_COMPLETE_INFO";

    [Token(Token = "0x60081CF")]
    [Address(RVA = "0x422030", Offset = "0x420E30", VA = "0x10422030")]
    private void Awake()
    {
    }

    [Token(Token = "0x60081D0")]
    [Address(RVA = "0x4220A0", Offset = "0x420EA0", VA = "0x104220A0")]
    private void Start()
    {
    }

    [Token(Token = "0x60081D1")]
    [Address(RVA = "0x4220A0", Offset = "0x420EA0", VA = "0x104220A0")]
    private void Init()
    {
    }

    [Token(Token = "0x60081D2")]
    [Address(RVA = "0x422120", Offset = "0x420F20", VA = "0x10422120")]
    private bool Refresh() => new bool();

    [Token(Token = "0x60081D3")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AdventureEffectWindow()
    {
    }
  }
}
