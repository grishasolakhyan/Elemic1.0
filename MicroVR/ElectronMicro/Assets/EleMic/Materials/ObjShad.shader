Shader "z/ObjShad"
{
    Properties
    {
		_SiONaMask ("SiONa Mask", 2D) = "white"{}
		_CaAlFeMask ("CaAlFe Mask", 2D) = "white"{}
		_CMgClMask ("CMgCl Mask", 2D) = "white"{}
		_AuMask ("Au Mask", 2D) = "white"{}
		
		_MainTex ("Main tex", 2D) = "white"{}
		
		_SiTex ("Si tex", 2D) = "white"{}
		_OTex ("O tex", 2D) = "white"{}
		_NaTex ("Na tex", 2D) = "white"{}
		
		_CaTex ("Ca tex", 2D) = "white"{}
		_FeTex ("Fe tex", 2D) = "white"{}
		_AlTex ("Al tex", 2D) = "white"{}
		
		_CTex ("C tex", 2D) = "white"{}
		_MgTex ("Mg tex", 2D) = "white"{}
		_ClTex ("Cl tex", 2D) = "white"{}
		_AuTex ("Au tex", 2D) = "white"{}
		
		_IntSi ("Si", int) = 0
		_IntO("O", int) = 0
		_IntNa("Na", int) = 0
		_IntCa("Ca", int) = 0
		_IntFe("Fe", int) = 0
		_IntAl("Al", int) = 0
		_IntC("C", int) = 0
		_IntMg("Mg", int) = 0
		_IntCl("Cl", int) = 0
		_IntAu("Au", int) = 0

		_BrightnessParam("Brightness", range (-100, 100)) = 0
		_OpacityParam("Opacity", range(0, 100)) = 100
		
    }
    SubShader
    {
        CGPROGRAM
			#pragma surface surf Lambert
			sampler2D
				_SiONaMask,
				_CaAlFeMask,
				_CMgClMask,
				_AuMask,
				
				_MainTex,
				
				_SiTex,
				_OTex,
				_NaTex,
				
				_CaTex,
				_AlTex,
				_FeTex,
				
				_CTex,
				_MgTex,
				_ClTex,
				
				_AuTex,
				_WhiteTex
			;
			fixed _BrightnessParam;
			fixed _OpacityParam;

			fixed _IntSi;
			fixed _IntO;
			fixed _IntNa;
			fixed _IntCa;
			fixed _IntFe;
			fixed _IntAl;
			fixed _IntC;
			fixed _IntMg;
			fixed _IntCl;
			fixed _IntAu;

			struct Input
			{
				half2 uv_SiONaMask;
				half2 uv_CaAlFeMask;
				half2 uv_CMgClMask;
				half2 uv_AuMask;
				
				half2 uv_MainTex;
				
				half2 uv_SiTex;
				half2 uv_OTex;
				half2 uv_NaTex;
				
				half2 uv_CaTex;
				half2 uv_AlTex;
				half2 uv_FeTex;
				
				half2 uv_CTex;
				half2 uv_MgTex;
				half2 uv_ClTex;
				
				half2 uv_AuTex;
			};
			
			void surf(Input inp, inout SurfaceOutput outp)
			{
				//Кремний, кислород, Натрий
				fixed3 si_masks = tex2D(_SiONaMask, inp.uv_SiONaMask).r;
				fixed3 o_masks = tex2D(_SiONaMask, inp.uv_SiONaMask).b;
				fixed3 na_masks = tex2D(_SiONaMask, inp.uv_SiONaMask).g;
				
				//Кальций, Алюминий, Железо
				fixed3 ca_masks = tex2D(_CaAlFeMask, inp.uv_CaAlFeMask).r;
				fixed3 fe_masks = tex2D(_CaAlFeMask, inp.uv_CaAlFeMask).b;
				fixed3 al_masks = tex2D(_CaAlFeMask, inp.uv_CaAlFeMask).g;
				
				//Углерод, магний, хлор
				fixed3 c_masks = tex2D(_CMgClMask, inp.uv_CMgClMask).r;
				fixed3 mg_masks = tex2D(_CMgClMask, inp.uv_CMgClMask).b;
				fixed3 cl_masks = tex2D(_CMgClMask, inp.uv_CMgClMask).g;

				fixed3 white_mask = tex2D(_SiONaMask, inp.uv_SiONaMask);
				
				//Золото
				fixed3 au_masks = tex2D(_AuMask, inp.uv_AuMask).r;
				
				//Главная текстура
				fixed3 maint = tex2D(_MainTex, inp.uv_MainTex);
				
				fixed3 si_clr = tex2D(_SiTex, inp.uv_SiTex) * si_masks;
				fixed3 o_clr = tex2D(_OTex, inp.uv_SiTex) * o_masks;
				fixed3 na_clr = tex2D(_NaTex, inp.uv_SiTex) * na_masks;
				
				fixed3 ca_clr = tex2D(_CaTex, inp.uv_SiTex) * ca_masks;
				fixed3 al_clr = tex2D(_AlTex, inp.uv_SiTex) * al_masks;
				fixed3 fe_clr = tex2D(_FeTex, inp.uv_SiTex) * fe_masks;
				
				fixed3 c_clr = tex2D(_CTex, inp.uv_SiTex) * c_masks;
				fixed3 mg_clr = tex2D(_MgTex, inp.uv_SiTex) * mg_masks;
				fixed3 cl_clr = tex2D(_ClTex, inp.uv_SiTex) * cl_masks;
				
				fixed3 au_clr = tex2D(_AuTex, inp.uv_SiTex) * au_masks;
				
				maint = maint + (si_clr * _IntSi + o_clr * _IntO + na_clr * _IntNa + ca_clr * _IntCa + fe_clr * _IntFe + al_clr*_IntAl) * _OpacityParam / 100 + _BrightnessParam / 100;
				outp.Albedo = maint;
			}
			
        ENDCG
    }
    FallBack "Diffuse"
}
