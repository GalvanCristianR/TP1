/*
 * Creado por SharpDevelop.
 * Usuario: Nelida
 * Fecha: 9/9/2021
 * Hora: 15:39
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Collections;

namespace actividad_5_complejidad
{
	
	class Program
	{
		public static void Main(string[] args)
		{
			
			ArbolGeneral<String> raiz = new ArbolGeneral<string>("RAIZ");
			
			ArbolGeneral<String> nodo1 = new ArbolGeneral<string>("A");
			ArbolGeneral<String> nodo2 = new ArbolGeneral<string>("B");
			ArbolGeneral<String> nodo3 = new ArbolGeneral<string>("C");
			ArbolGeneral<String> nodo4 = new ArbolGeneral<string>("D");
			ArbolGeneral<String> nodo5 = new ArbolGeneral<string>("E");
			
			ArbolGeneral<String> hoja1 = new ArbolGeneral<string>("H1");
			ArbolGeneral<String> hoja2 = new ArbolGeneral<string>("H2");
			ArbolGeneral<String> hoja3 = new ArbolGeneral<string>("H3");
			
			ArbolGeneral<String> hoja4 = new ArbolGeneral<string>("H4");
			ArbolGeneral<String> hoja5 = new ArbolGeneral<string>("H5");
			ArbolGeneral<String> hoja6 = new ArbolGeneral<string>("H6");
			
			ArbolGeneral<String> hoja7 = new ArbolGeneral<string>("H7");
			ArbolGeneral<String> hoja8 = new ArbolGeneral<string>("H8");
			ArbolGeneral<String> hoja9 = new ArbolGeneral<string>("H9");
			
			ArbolGeneral<String> hoja10 = new ArbolGeneral<string>("H10");
			ArbolGeneral<String> hoja11 = new ArbolGeneral<string>("H11");
			ArbolGeneral<String> hoja12 = new ArbolGeneral<string>("H12");
			
			ArbolGeneral<String> hoja13 = new ArbolGeneral<string>("H13");
			ArbolGeneral<String> hoja14 = new ArbolGeneral<string>("H14");
			
			raiz.agregarHijo(nodo1);
			raiz.agregarHijo(nodo2);
			raiz.agregarHijo(nodo3);
			raiz.agregarHijo(nodo4);
			raiz.agregarHijo(nodo5);
			
			nodo1.agregarHijo(hoja1);
			nodo1.agregarHijo(hoja2);
			nodo1.agregarHijo(hoja3);
			nodo1.agregarHijo(hoja3);
			
			nodo2.agregarHijo(hoja4);
			nodo2.agregarHijo(hoja5);
			nodo2.agregarHijo(hoja6);
			
			nodo3.agregarHijo(hoja7);
			nodo3.agregarHijo(hoja8);
			nodo3.agregarHijo(hoja9);
			
			nodo4.agregarHijo(hoja10);
			nodo4.agregarHijo(hoja11);
			nodo4.agregarHijo(hoja12);
			nodo4.agregarHijo(hoja14);
			
			nodo5.agregarHijo(hoja13);
			hoja13.agregarHijo(hoja14);
			
			//raiz.imprimirDatoYNivel(0);
			//Console.WriteLine("------------------------");
			int litros=1000;
			
			//raiz.porNiveles();
			raiz.porNivelesActividad(litros);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}