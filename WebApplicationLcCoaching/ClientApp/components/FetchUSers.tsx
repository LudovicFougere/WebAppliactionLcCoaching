import * as React from 'react';
import { RouteComponentProps } from 'react-router';
import { Link, NavLink } from 'react-router-dom';

interface FetchUsersDataState {
    empList: UserData[];
    loading: boolean;
}

export class FetchUsers extends React.Component<RouteComponentProps<{}>, FetchUsersDataState> {

    constructor() {
        super();
        this.state = { empList: [], loading: true };

        fetch('api/User/Index')
            .then(response => response.json() as Promise<UserData[]>)
            .then(data => {
                this.setState({ empList: data, loading: false });
            });

        // This binding is necessary to make "this" work in the callback 
        this.handleDelete = this.handleDelete.bind(this);
        this.handleEdit = this.handleEdit.bind(this);

    }

    public render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : this.renderEmployeeTable(this.state.empList);

        return <div>
            <h1>Users Data</h1>
            <p>This component demonstrates fetching Employee data from the server.</p>
            <p>
                <Link to="/adduser">Create New</Link>
            </p>
            {contents}
        </div>;
    }

    // Handle Delete request for an employee 
    private handleDelete(id: number) {
        if (!confirm("Do you want to delete employee with Id: " + id))
            return;
        else {
            fetch('api/User/Delete/' + id, {
                method: 'delete'
            }).then(data => {
                this.setState(
                    {
                        empList: this.state.empList.filter((rec) => {
                            return (rec.userId != id);
                        })
                    });
            });
        }
    }

    private handleEdit(id: number) {
        this.props.history.push("/user/edit/" + id);
    }

    // Returns the HTML table to the render() method. 
    private renderEmployeeTable(empList: UserData[]) {
        return <table className='table'>
            <thead>
                <tr>
                    <th></th>
                    <th>UserId</th>
                    <th>Nom</th>
                    <th>Prenom</th>
                    <th>Age</th>
                    <th>Sexe</th>
                    <th>Date Limite</th>
                </tr>
            </thead>
            <tbody>
                {empList.map(emp =>
                    <tr key={emp.userId}>
                        <td></td>
                        <td>{emp.userId}</td>
                        <td>{emp.nom}</td>
                        <td>{emp.prenom}</td>
                        <td>{emp.age}</td>
                        <td>{emp.gender}</td>
                        <td>{emp.dateLimite}</td>
                        <td>
                            <a className="action" onClick={(id) => this.handleEdit(emp.userId)}>Edit</a>  |
                            <a className="action" onClick={(id) => this.handleDelete(emp.userId)}>Delete</a>
                        </td>
                    </tr>
                )}
            </tbody>
        </table>;
    }

}


export class UserData {
    userId: number = 0;
    nom: string = "";
    prenom: string = "";
    age: string = "";
    gender: string = "";
    dateLimite: string = "";
}