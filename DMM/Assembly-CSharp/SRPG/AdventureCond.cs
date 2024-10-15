// Decompiled with JetBrains decompiler
// Type: SRPG.AdventureCond
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F7B")]
  [AddComponentMenu("UI/Adventure/AdventureCond")]
  public class AdventureCond : MonoBehaviour
  {
    [Token(Token = "0x40084FC")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ImageArray CondStateImages;
    [Token(Token = "0x40084FD")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text CondText;
    [Token(Token = "0x40084FE")]
    [FieldOffset(Offset = "0x14")]
    private AdventureCondParam mParam;
    [Token(Token = "0x40084FF")]
    [FieldOffset(Offset = "0x18")]
    private AdventureCondParam.Cond mCondParam;

    [Token(Token = "0x6008161")]
    [Address(RVA = "0x41ED20", Offset = "0x41DB20", VA = "0x1041ED20")]
    public void SetUp(AdventureCondParam _param, int _index, PartyData _party)
    {
    }

    [Token(Token = "0x6008162")]
    [Address(RVA = "0x41E400", Offset = "0x41D200", VA = "0x1041E400")]
    public void ChangeCondImage(PartyData _party)
    {
    }

    [Token(Token = "0x6008163")]
    [Address(RVA = "0x41E4E0", Offset = "0x41D2E0", VA = "0x1041E4E0")]
    private void SetCondText()
    {
    }

    [Token(Token = "0x6008164")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AdventureCond()
    {
    }

    [Token(Token = "0x2001F7C")]
    private enum CondState
    {
      [Token(Token = "0x4008501")] None,
      [Token(Token = "0x4008502")] Clear,
    }
  }
}
