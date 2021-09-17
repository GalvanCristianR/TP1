/*
 * Creado por SharpDevelop.
 * Usuario: Nelida
 * Fecha: 17/9/2021
 * Hora: 19:30
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Collections;

namespace actividad_5_complejidad
{
	public class ArbolGeneral<T>
	{
		
		private T dato;
		private List<ArbolGeneral<T>> hijos = new List<ArbolGeneral<T>>();

		public ArbolGeneral(T dato) {
			this.dato = dato;
		}
	
		public T getDatoRaiz() {
			return this.dato;
		}
	
		public List<ArbolGeneral<T>> getHijos() {
			return hijos;
		}
	
		public void agregarHijo(ArbolGeneral<T> hijo) {
			this.getHijos().Add(hijo);
		}
	
		public void eliminarHijo(ArbolGeneral<T> hijo) {
			this.getHijos().Remove(hijo);
		}
	
		public bool esHoja() {
			return this.getHijos().Count == 0;
		}
	
		public int altura() {
			return 0;
		}
	
		
		public int nivel(T dato) {
			return 0;
		}

		public void preOrden(){
		Console.WriteLine(this.getDatoRaiz());
		foreach(ArbolGeneral<T> hijo in this.getHijos()){
			hijo.preOrden();
		}

		}
		
		public void imprimirDatoYNivel(int nivel){
			Console.WriteLine("Mi dato es {0}, y esto es en el nivel {1}",this.getDatoRaiz(),nivel);
			foreach(ArbolGeneral<T> hijo in getHijos()){
				hijo.imprimirDatoYNivel(nivel+1);
				
			}
		}
		
		
		
		
		public void porNivelesActividad(int agua)
		{
			Cola<ArbolGeneral<T>> c = new Cola<ArbolGeneral<T>>();
			ArbolGeneral<T> arbolAux;
			List<double> lista1= new List<double>();
			
			c.encolar(this);
			int cant=0;
			int cont=0;
			lista1.Add(agua);
			
			
			while(!c.esVacia())
			{
				
					arbolAux = c.desencolar();
					
					
						if(!this.esHoja())
						{	
							
				   			foreach(var hijo in arbolAux.getHijos())
				  			{
				   				
				      			c.encolar(hijo);
				      			cant++;
				      			
				      		}
				   		}
						
						
						double agua2=lista1[0+cont]/cant;
						
						
						for (int i=0;i<cant;i++){
							
							
							Console.WriteLine(arbolAux.getDatoRaiz() + " " + agua2 );
							lista1.Add(agua2);
							
						}
						
						
						cont++;
						
						cant=0;
						
						
					
					
			
			}
			//for(int i=0;i<lista1.Count;i++){
			//	
			//	Console.WriteLine(lista1[i]);
				
			//}
		}	
		
		public void porNiveles(){
			Cola<ArbolGeneral<T>> c = new Cola<ArbolGeneral<T>>();
			c.encolar(this);
			int nivelActual=0;
			
			while(!c.esVacia()){
				int elementoPorNivel = c.cantElem();
				Console.WriteLine("Nivel {0}: ", nivelActual);
				
				while(elementoPorNivel-- > 0){
					ArbolGeneral<T> nodo=c.desencolar();
					
					Console.Write(nodo.getDatoRaiz()+" ");
					foreach(ArbolGeneral<T> hijo in nodo.getHijos()){
						c.encolar(hijo);
						
					}
				}
				
				nivelActual++;
				Console.WriteLine();
			}
			
			
			
		}
	
	}
}
