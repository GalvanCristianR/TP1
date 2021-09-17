/*
 * Creado por SharpDevelop.
 * Usuario: Nelida
 * Fecha: 17/9/2021
 * Hora: 19:28
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Collections;

namespace actividad_5_complejidad
{
	public class Cola<T>
	{

		
		private List<T> datos = new List<T>();
	
		public void encolar(T elem) {
			this.datos.Add(elem);
		}
	
		public T desencolar() {
			T temp = this.datos[0];
			this.datos.RemoveAt(0);
			return temp;
		}
		
		public T tope() {
			return this.datos[0]; 
		}
		
		public bool esVacia() {
			return this.datos.Count == 0;
		}
		
		public int cantElem(){
			return this.datos.Count;
		}
		
	}
}
